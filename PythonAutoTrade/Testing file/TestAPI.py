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

# stock = "HVN"
# url = str(requests.get("https://www.alphavantage.co/query?function=TIME_SERIES_WEEKLY_ADJUSTED&symbol=ASX:"+stock+"&apikey=TFCHTUSZ0Y3TBTJP").content)
# jsonFormated = json.dumps(url)

# jsonFormated = jsonFormated.replace("\"b'","").replace("\\n","").replace(" ","").replace("\\","").replace("'\"","").replace(",\"7.dividendamount\":\"0.0000\"","")

# file = open("StokeData.json","w")
# file.write(jsonFormated)
# file.close()



file = open("StokeData.json","r")
jsonFormated = json.loads(file.read())
file.close()


upSwing = []
downTurn = []
currentTrend = []
Xswing = []
Xturn = []
trendLen = []


def GraphTrends(jsonFormated):
	global upSwing,downTurn,currentTrend
	provPrice = 0
	flip = True
	aline = True
	cnt = -1

	#  detect trends 
	for stokeprice in jsonFormated["WeeklyAdjustedTimeSeries"]:
		price = float(jsonFormated["WeeklyAdjustedTimeSeries"][stokeprice]["4.close"])
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
		
GraphTrends(jsonFormated)



# Plot the graph 	
f = plt.figure()
ax = f.add_subplot(111)
ax.yaxis.tick_right()
ax.yaxis.set_ticks_position('both')

plt.grid(True)
plt.margins(x=0, y=0.1)
plt.xticks(rotation=45)
plt.gca().invert_xaxis()



for u in range(len(upSwing)):
	ax.plot(Xswing[u],upSwing[u],color="teal")

for d in range(len(downTurn)):
	ax.plot(Xturn[d],downTurn[d],color="red")



plt.title('Stoke Data')
plt.ylabel('$Price')
plt.xlabel('Time')
plt.show()
