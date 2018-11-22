import requests
import json
import sys
from matplotlib import pyplot as plt
import pandas as pd
import numpy as np
import math
import time
import random
import matplotlib.patches as mpatches


def getStockData(stock):
	url = str(requests.get("https://www.alphavantage.co/query?function=TIME_SERIES_DAILY_ADJUSTED&symbol=ASX:"+stock+"&apikey=TFCHTUSZ0Y3TBTJP").content)
	jsonFormated = json.dumps(url)

	return	json.loads(jsonFormated.replace("\"b'","").replace("\\n","").replace(" ","").replace("\\","").replace("'\"","").replace(",\"7.dividendamount\":\"0.0000\"",""))



def GraphTrends(jsonFormated):
	upSwing = []
	downTurn = []
	currentTrend = []
	Xswing = []
	Xturn = []
	trendLen = []
	provPrice = 0
	flip = True
	aline = True
	cnt = -1

	#  detect trends 
	for stokeprice in jsonFormated["TimeSeries(Daily)"]:
		price = float(jsonFormated["TimeSeries(Daily)"][stokeprice]["4.close"])
		cnt+=1

		if provPrice > price:
			if flip == True or aline == True:
				if len(currentTrend) >= 2:
					downTurn.append(currentTrend)
					Xturn.append(trendLen)

				currentTrend = []
				trendLen = []
				flip = False
				aline = False

			currentTrend.append(price)
			trendLen.append(cnt)

		elif provPrice <= price:
			if flip == False or aline == True:
				if len(currentTrend) >= 2:
					upSwing.append(currentTrend)
					Xswing.append(trendLen)

				currentTrend = []
				trendLen = []
				flip = True
				aline = False

			currentTrend.append(price)
			trendLen.append(cnt)
		provPrice = price

	return downTurn,upSwing


# Give a score on what to buy
def buyChance(StokeData):
	avr = []
	avrange = []
	buy = 0

	for c in range(len(StokeData[0])):
		avr.append(np.mean(StokeData[0][c]))
	
	for d in range(len(avr)):
		if d < len(avr)-2:
			avrange.append(abs(avr[d] - avr[d+1]))
	
	for f in range(len(avrange)):
		if f < len(avrange)-1:
			if(avrange[((len(avrange)-1)-f)] > avrange[((len(avrange)-2)-f)]):
				buy+=1
			else:
				buy = 0
	return buy


measure = True
def mainAction(Companies):
	print("----- mainAction ----- Active\nPlease wait while i look...")
	
	c = -1
	tracker = 0
	ProfitableStock = []
	while c < len(Companies)-1:
		c+=1

		try:
			percent = buyChance(GraphTrends(getStockData(Companies[c])))
			measure = True
		except Exception as e:
			print("API has timed out\nWorking on countermeasure\nThis may take some time")
			measure = False
			
			tracker+=1
			
			# Checks how many times this side of function has fired
			if tracker > 4:
				print(ProfitableStock)
				return print("Failed to gether")

			time.sleep(20)
			print("Countermeasure Complete")

		
		if measure is True:
			tracker = 0

			if  percent == 3:
				ProfitableStock.append(Companies[c]+"**")
				print(Companies[c]+"**")
			elif percent == 2:
				ProfitableStock.append(Companies[c]+"*")
				print(Companies[c]+"*")
			elif percent > 3:
				ProfitableStock.append(Companies[c]+"***")
				print(Companies[c]+"***")

		if c >= len(Companies)-1:
			return ProfitableStock