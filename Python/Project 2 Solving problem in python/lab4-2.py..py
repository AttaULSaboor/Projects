
#Get the value from user for three variable a,b,c
a=int(input("please enter a variable :"))
b=int(input("please enter b variable :"))
c=int(input("please enter a variable :"))

#Calculate formula 1
formula_1=-b-(((b**2-4*a*c)**0.5)/2*a)

#Calculate formula 2
formula_2=-b+(((b**2-4*a*c)**0.5)/2*a)

#Store false in a variable called result
print("It is " +str((formula_1 >= 0 and formula_2 >= 0)) + " that Formula 1 and Formula 2’s answers are both positive.")


