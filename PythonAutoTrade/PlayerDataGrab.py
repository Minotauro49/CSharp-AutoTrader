from bs4 import BeautifulSoup
import requests
import json
import sys


def loginDetails():
	loginDetails = open("loginDetails.json","r")
	logins = json.loads(loginDetails.read())
	loginDetails.close()

	return logins


loginURL = 'https://myasx.asx.com.au/home/login'
payload = loginDetails()


# navigates through secure urls


# logs a user in their profile
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
def Username():
	pageContent = UserAuthentication(payload,loginURL,1,0,False,None)

	playerName =  pageContent.find('div', {'class': 'page'})
	playerName = playerName.find('h3').text

	# Stops program if login Fails
	if playerName[:7] != "Welcome":
		jsonFile = open("PlayerData.json","r")
		attempts = json.loads(jsonFile.read())

		# Logs attempts when user fails to login
		try:
			if attempts["login"] == True:
				tryLogin = False
			else:
				tryLogin = True	
		except Exception as e:
			tryLogin = False

		if tryLogin == True:
			PlayerData = {"login":False,"Attempts":attempts["Attempts"]+1}
		else:
			PlayerData = {"login":False,"Attempts":1}
		jsonFile.close()

		jsonFile = open("PlayerData.json","w")
		jsonFile.write(json.dumps(PlayerData))
		jsonFile.close()

		sys.exit("login Failed")

	return playerName[8:]


# gets the players current profit
def PlayerProfit():
	pageContent = UserAuthentication(payload,loginURL,1,0,True,None)
	# playerProfit =  pageContent.findAll('tr')
	dataTr = []
	cnt = 0
	for row in pageContent.findAll('td'):
		dataTr.append(row)
		cnt+=1

		if cnt > 5: # get the data i want and break the loop
			break

	profit = "Password maybe incorrect"
	try:
		profit = float("{0:.3f}".format(float(dataTr[5].text[1:].replace(",",""))-50000))#50000 is the start up amount of your portfolio 
	except Exception as e:
		raise e

	return profit 


# Puts all data in a json formated file
def ProfileData():
	PlayerData = {
		"login":True,
		"Name":Username(),
		"Profit":PlayerProfit()
	}

	jsonFile = open("PlayerData.json","w")
	jsonFile.write(json.dumps(PlayerData))
	jsonFile.close()

# ProfileData()



 ###### Testing application  ######

def AllShares():
	pageContent = UserAuthentication(payload,loginURL,2,0,True,None)

	companyShares = {}
	cnt = 0

	for a in pageContent.findAll('tbody'):
		cnt+=1
		campanyName = a.find("td").text.replace("\t" ,"").replace("\n" ,"").replace("  " ,"") # removes any tabs or newline
		link = a.find("a").get('href'); # gets href of Shares
		code = link[(link.index("companies")+10):]

		companyShares.update({code:{"Company_Name":campanyName,"Link":link}})# "https://game.asx.com.au"

	jsonFile = open("companyShares.json","w")
	jsonFile.write(json.dumps(companyShares))
	jsonFile.close()
	return companyShares #allCompanyShares#allCompanyShares

# AllShares()
# print(AllShares())



def CompanyAnalyse():
	dataFileShares = open("companyShares.json","r")
	companyShares = json.loads(dataFileShares.read())
	dataFileShares.close()


	for index, (key, value) in enumerate(companyShares.items()):
		pageContent = UserAuthentication(payload,loginURL,2,0,True,("https://game.asx.com.au"+companyShares[key]["Link"]))
		break;
	
	return pageContent


print(CompanyAnalyse())





# enumerate





#def MySharesURL():
#	pageContent = UserAuthentication(payload,loginURL,1,0,False)
#
#	myShares = {}
#	cnt = 0
#	for a in pageContent.findAll('tbody'):
#		cnt+=1
#
#		if cnt > 1:
#			index = a.find("a").text.replace("\t" ,"").replace("\n" ,"") # removes any tabs or newline
#			myShares[index] = a.find("a").get('href'); # gets href of  my Shares
#
#	return myShares
# print(MySharesURL())









sys.exit()


