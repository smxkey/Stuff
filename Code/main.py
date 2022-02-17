import time
import os
import sys
import pyautogui

input_usr1 = input("Start Valorant? or no? |Y/N| : ")

if input_usr1 == ("Y"):
    pyautogui.press('win')
    time.sleep(0.8)
    pyautogui.write('Valorant', interval=0.25)
    time.sleep(0.3)
    pyautogui.press('enter')
    time.sleep(0.1)
    quit()

if input_usr1 == ("N"):
    print("aight")
    time.sleep(2)



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
            time.sleep(0.1)

        else:
            time.sleep(0.5)

os.system("cls")

typewriter(ur_message)

time.sleep(1)

usr1 = '''
  1) Open Crypto   | 2) Close Menu
  -
  3) Open Valorant | 4) Power Options

'''
def typewriter(usr1):
    for char in usr1:
        sys.stdout.write(char)
        sys.stdout.flush()

        if char != "\n":
            time.sleep(0.1)

        else:
            time.sleep(0.5)

os.system("cls")

typewriter(usr1)

usr2 = input(''' Type number to continue: ''')

if usr2 == ("1"):
    print('''
    
     Confirming your request..''')
    time.sleep(0.3)
    yn = pyautogui.confirm(text='Are you sure you want to open Crypto?', title='Crypto', buttons=['Yes', 'No'])

    if yn != ("Yes"): #this is no
        print("ok")
        time.sleep(3)

    if yn != ("No"): #this is yes
        os.startfile("\\Users\\pcmcb\\Desktop\\crypto")

if usr2 == ("2"):

    print('''
Closing''')

    time.sleep(0.3)

    print('''
closing assets''')

    time.sleep(0.5)

    usr3 = '''
.'''
    usr4 = '''
..'''
    usr5 = '''
...'''
    usr6 = '''
.'''
    usr7 = '''
..'''
    usr8 = '''
...'''



    def typewriter(usr3):

     for char in usr3:
         sys.stdout.write(char)
         sys.stdout.flush()
 
         if char != "\n":
             time.sleep(0.1)
 
         else:
             time.sleep(0.5)

    def typewriter(usr4):

     for char in usr4:
         sys.stdout.write(char)
         sys.stdout.flush()
 
         if char != "\n":
             time.sleep(0.1)
 
         else:
             time.sleep(0.5)

    def typewriter(usr5):

     for char in usr5:
         sys.stdout.write(char)
         sys.stdout.flush()
 
         if char != "\n":
             time.sleep(0.1)
 
         else:
             time.sleep(0.5)

    def typewriter(usr6):

     for char in usr6:
         sys.stdout.write(char)
         sys.stdout.flush()
 
         if char != "\n":
             time.sleep(0.1)
 
         else:
             time.sleep(0.5)

    def typewriter(usr7):

     for char in usr7:
         sys.stdout.write(char)
         sys.stdout.flush()
 
         if char != "\n":
             time.sleep(0.1)
 
         else:
             time.sleep(0.5)

    def typewriter(usr8):

     for char in usr8:
         sys.stdout.write(char)
         sys.stdout.flush()
 
         if char != "\n":
             time.sleep(0.1)
 
         else:
             time.sleep(0.5)

    time.sleep(5)

os.system("cls")

typewriter(usr3)

typewriter(usr4)

typewriter(usr5)

typewriter(usr6)

typewriter(usr7)

typewriter(usr8)

time.sleep(2)


if usr2 == ("3"):
    print('''
    
     Confirming your request..''')
    time.sleep(0.3)
    yn = pyautogui.confirm(text='Are you sure you want to open Valorant?', title='Valorant', buttons=['Yes', 'No'])

    if yn != ("Yes"): #this is no
        print("ok")
        time.sleep(3)

    if yn != ("No"): #this is yes
        pyautogui.press('win')
        time.sleep(0.8)
        pyautogui.write('Valorant', interval=0.25)
        time.sleep(2)


else:
    print("chose only number between 1, 2, 3 and 4 ")


