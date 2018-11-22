from bs4 import BeautifulSoup
from AssessStock import mainAction
import requests
import json
import sys
import re
import os.path




def loginDetails():
	loginDetails = open("loginDetails.json","r")
	logins = json.loads(loginDetails.read())
	loginDetails.close()

	return logins


loginURL = 'https://myasx.asx.com.au/home/login'
payload = loginDetails()




# navigates through secure urls to log on my account in their profile
def UserAuthentication(payload,loginURL,defaultNav,securityNav,bridge,pageNav):
	SecurepageNav = {
		"0":"https://myasx.asx.com.au/home/premiumService.do?serviceCode=SMG1&display=true",
		"1":"https://game.asx.com.au/game/play/public/2018-2/portfolio",
		"2":"https://game.asx.com.au/game/play/public/2018-2/companies" # give access to all shares 
	}

	session = requests.Session()
	session.post(loginURL, data=payload)

	if bridge == True:
		session.post(SecurepageNav[str(securityNav)])

	if pageNav == None:
		html = session.get(SecurepageNav[str(defaultNav)]).content
	else:
		html = session.get(pageNav).content

	soup = BeautifulSoup(html, "html.parser")

	return soup



# gets the players name
def playerDetail():
	holding = []
	status = []
	profit = ""
	cnt = 0

	# pageContent = UserAuthentication(payload,loginURL,1,0,True,"https://game.asx.com.au/game/play/public/2018-2/portfolio")
	pageContent = UserAuthentication(payload,loginURL,1,0,True,"https://game.asx.com.au/game/play/public/2018-2/portfolio")

	print(pageContent)
	name = pageContent.find('a', {'class': 'user-name'}).text # Get player MY name

	# Scrape data about my profile
	for x in pageContent.findAll("td"):
		if cnt < 6:
			cnt+=1
			if cnt%2 == 0:
				status.append((x.text)[1:].replace(",",""))

		if x.find('a') !=None:
			hold = (x.find('a').text).replace("	", "")
			if re.search('[a-zA-Z]', hold) !=None and hold !=None:
				holding.append(hold.replace("\n",""))

	# profit calculator
	profit = float(status[2]) - 50000
	if profit < 0:
		profit = "none"

	playerProfile = {"Name":name,"playerHolding":holding[1:],"Cash":status[0],"Invested":status[1],"PortfolioValue":status[2],"Profit":profit}

	jsonFile = open("PlayerData.json","w")
	jsonFile.write(json.dumps(playerProfile))
	jsonFile.close()

	return playerProfile["playerProfile"]

playerHolding = playerDetail()


 ###### Getting Codes for all companies names  ######
def AllShares():
	filePath = "companyShares.json"

	if os.path.isfile(filePath)!= True or os.path.getsize(filePath) < 1:
		pageContent = UserAuthentication(payload,loginURL,2,0,True,None)
		companyShares = {}
		cnt = 0
	
		for a in pageContent.findAll('tbody'):
			cnt+=1
			campanyName = a.find("td").text.replace("\t" ,"").replace("\n" ,"").replace("  " ,"") # removes any tabs or newline
			link = a.find("a").get('href'); # gets href of Shares
			code = link[(link.index("companies")+10):]
	
			companyShares.update({code:{"Company_Name":campanyName,"Link":link}})# "https://game.asx.com.au"
	
		jsonFile = open(filePath,"w")
		jsonFile.write(json.dumps(companyShares))
		jsonFile.close()

AllShares()


def CompanyAnalyse():
	global playerHolding

	dataFileShares = open("companyShares.json","r")
	companyShares = json.loads(dataFileShares.read())
	dataFileShares.close()
	shares = []

	print(playerHolding)
	for index, (key, value) in enumerate(companyShares.items()):
		# shares.append(key)
		if (key in playerHolding) != True:
			shares.append(key)

	Suggested = open("SuggestedShares.json","w")
	Suggested.write(json.dumps({"Suggested":mainAction(shares)}))
	Suggested.close()

CompanyAnalyse()


sys.exit()


