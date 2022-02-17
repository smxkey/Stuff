# |-------------------------|
# | Copytight to smoky#7017 |
# |-------------------------|
#
# This is free to use but please tag smoky#7017 it will mean everything if you do!!

# Imports
from time import sleep as ss
import pyautogui
import sys
import os

# checks if password file exist
# anf if then removes it for new one
# to be created after user typed the password
if os.path.exists("pass.txt"):
  os.remove("pass.txt")


# welcoming message
ur_message = '''
 ---------
 | Hello |
 ---------
'''

def typewriter(ur_message):
    for char in ur_message:
        sys.stdout.write(char)
        sys.stdout.flush()

        if char != "\n":
            ss(0.1)

        else:
            ss(0.5)

os.system("cls")

typewriter(ur_message)

os.system("cls")

print("Can I ask..")

usr_name = input("\nWhat your name is?: ")

os.system("cls")

print("Can I also ask...")

usr_age = input("\nHow old you are?: ")

os.system("cls")

print("Can I also ask....")

usr_pass = input("\nWhat password you want to use for later?: ")






# Loading bar for preogress from name, age and password //
def loadbar(iteration, total, prefix='', suffix='', decimals=1, length=100, fill='>'):
    percent = ('{0:.' + str(decimals) + 'f}').format(100 * (iteration/float(total)))
    filledLength = int(length * iteration // total)
    bar = fill * filledLength + '-' * (length - filledLength)
    print(f'\r{prefix} |{bar}| {percent}% {suffix}', end='\r')
    if iteration == total:
        print()

items = list(range(0, 50))
l = len(items)

loadbar(0, l, prefix='Progressing name:', suffix='Complete', length=l)
for i, items in enumerate(items):
    ss(0.1)
    loadbar(i + 1, l, prefix='Progressing name:', suffix='Complete', length=l)

ss(0.2)

def loadbar(iteration, total, prefix='', suffix='', decimals=1, length=100, fill='>'):
    percent = ('{0:.' + str(decimals) + 'f}').format(100 * (iteration/float(total)))
    filledLength = int(length * iteration // total)
    bar = fill * filledLength + '-' * (length - filledLength)
    print(f'\r{prefix} |{bar}| {percent}% {suffix}', end='\r')
    if iteration == total:
        print()

items = list(range(0, 50))
l = len(items)

loadbar(0, l, prefix='Progressing age:', suffix='Complete', length=l)
for i, items in enumerate(items):
    ss(0.1)
    loadbar(i + 1, l, prefix='Progressing age:', suffix='Complete', length=l)

ss(0.2)

def loadbar(iteration, total, prefix='', suffix='', decimals=1, length=100, fill='>'):
    percent = ('{0:.' + str(decimals) + 'f}').format(100 * (iteration/float(total)))
    filledLength = int(length * iteration // total)
    bar = fill * filledLength + '-' * (length - filledLength)
    print(f'\r{prefix} |{bar}| {percent}% {suffix}', end='\r')
    if iteration == total:
        print()

items = list(range(0, 50))
l = len(items)

# password data
f = open("pass.txt", "x")

f = open("pass.txt", "w")

f.write(usr_pass)

f.close()

ss(0.1)

loadbar(0, l, prefix='Progressing pass:', suffix='Complete', length=l)
for i, items in enumerate(items):
    ss(0.1)
    loadbar(i + 1, l, prefix='Progressing pass:', suffix='Complete', length=l)

os.system("cls")


