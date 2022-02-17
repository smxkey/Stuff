from time import sleep as ss
#from Register import *
import pyautogui
import sys
import os

f = open("pass.txt", "r")

pass_file = f.read()

pass_check = pyautogui.password(text='Type the password you used early on.', title='Login', default='', mask='•')

if pass_check == pass_file:
    print("Password is correct")

else:
    print("Remember use the password you typed at the start... try again by restarting the file and using new password (It can be the same)")

ss(2)

os.system("cls")

ss(2)

os.startfile("\Debug\SearchableMenu.exe")