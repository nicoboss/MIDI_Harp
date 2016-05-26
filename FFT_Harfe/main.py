'''
FFT_Harfe von Nico Bosshard (c)2016
'''

from __future__ import print_function
import os, sys, threading, math, time
from random import *

Code = []
Data = []

mic=[44,63,88,24,65,87,98,9,12,23,34,45,56,67,78,89] #random numbers

comp=["==","!=","<",">"] #comparison operations
oper=[" and ", " or "] #boolean operations later maybe useing binary bitwise operations
moper=["+","*","**"] #arithmetic operations

for a in range(1000):
    cmd="if "
    for i in range(0,2):
        pos=mic.__len__()-i
        cmd+="mic[pos-"+str(i)+"]"+comp[randint(0,3)]+str(randint(0,255))+oper[randint(0,1)]
    cmd+="mic[pos-"+str(i)+"]"+comp[randint(0,3)]+str(randint(0,255)) + ": Data.append(1)\nelse: Data.append(0)"
    Code.append(cmd)
    #print(cmd)
    exec(cmd)
    print(Data[Data.__len__()-1],end='') #too slow

#print(Data)
