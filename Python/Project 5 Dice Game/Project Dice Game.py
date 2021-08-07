
# get value of dice
def diceValue():
  dice = []
  for randomValue in range(5):
    dice.insert(randomValue, random.randint(1,6)) 
  return sorted(dice)

# Count the value of dice 
def CountDice(dices):
  diceLength = len(dices) - 1
  count = 0
  diceValueCount = {}
  while(count < diceLength):
    currentDice = dices[count]
    nextDice = dices[count + 1]
    if(not(currentDice in diceValueCount.keys())):
       diceValueCount.__setitem__(currentDice, 1)
    if(not(nextDice in diceValueCount.keys())):
       diceValueCount.__setitem__(nextDice, 1)
    if currentDice == nextDice:
        if(currentDice in diceValueCount.keys()):
          diceCountValue = diceValueCount.get(currentDice)
          diceValueCount.__setitem__(currentDice, diceCountValue + 1)
    count = count + 1    
  return diceValueCount

# Identify number
def isPrime(num):
    flag = True
    for val in range(2, num):
        if num % val == 0:
            flag = False
            break
    return flag
  
# get score
def getScore(diceValueCount):
    score = 0;
    userInput = ""
    if (len(diceValueCount) == 1):
      score = 100
      userInput = "Would you like to score the points for all same values (100 points)? [y/n] :: "
    elif isPrime(addDiceValues(diceValueCount)):
      score = 50
      userInput = "Would you like to score the points for all 5 dice add up to a prime number (50 points)? [y/n] :: "
    elif(compareValues(diceValueCount)):  
      score = 30
      userInput = "Would you like to score the points for 3 of 5 dice have the same value (30 points)? [y/n] :: "
    elif(len(diceValueCount) == 5):  
      score = 25
      userInput = "Would you like to score the points for all 5 dice different values (25 points)? [y/n] :: "

    return score,userInput
  
# Add of values
def addDiceValues(dices):
  sumValue = 0
  for dice in dices.keys():
    sumValue = sumValue + dice
  return sumValue

# compare the values
def compareValues(diceValueCount):
  for value in diceValueCount.values():
    if value == 3:
      return True;
  return False

# Display total score
def outputStatements(totalScore, score, turn):
    totalScore = totalScore + score
    print("Your score now " + str(totalScore) + " points. Taking points ended your turn.End of turn "+str(turn)+".")
    if(turn == 10): 
      print("Total score is :",totalScore)
    return totalScore
  
# Updated dice
def updateDice(oldDice):
    diceIsUpdated = False
    for count in range(5):
      
       userInputStatement = "Would you like to reroll dice "+ str(count + 1)+"?[y/n] ::"
       if validateInput(userInputStatement) == 'y':
          oldDice[count] = random.randint(1,6)
          diceIsUpdated = True
     
    if not(diceIsUpdated):
      print("You didn't reroll any dice or score any points, please try again.")
      
    return oldDice
# validate user input  
def validateInput(userInputStatement):
  userInput = input(userInputStatement)
  userYesInput = ["YES", "yes", "Y", "y", "Yes", "yEs", "yES", "yeE", "YeS"];
  userNOInput = ["NO", "no", "N", "n", "No", "nO"];
  if userInput in userYesInput:
     userInput = 'y'
  elif userInput in userNOInput:    
     userInput = 'n'
  else:
    while not(userInput == 'y' or userInput == 'n'):
      print(userInput + ", is not a valid choice, please enter y or n.")
      userInput = input(userInputStatement)
      
  return userInput  

# Main program     
import random
print("Programming Fundamentals 201935, Atta UL Saboor, 000395780")
firstName = input("Welcome to my game, what is your first name? ")

# User first name is valid or not
while(not(firstName.isalpha())):
  firstName = input("I'm Sorry "+ firstName +", names are only allowed to contain letters.Please re-enter your name: ")  
  if (firstName.isalpha()): break;
print("Thank you Steve " + firstName + ", you start off with 0 points, let's play !")

# Use to track the score
totalScore = 0

# Loop for number of turns
for turn in range(1, 11):  
  print("Turn " + str(turn) + " :")
  count = 0
  turnScore = 0
  score = 0

  # Loop rerolled turns
  while count <= 3:
    if count == 0:
      dice  = diceValue()
    else:
      dice = updateDice(dice)
      
    diceValueCount = CountDice(dice)
    score,userInputStatement = getScore(diceValueCount)
    print("You rolled 5 dice. There values are "+str(dice) + " .")
    if score == 0:
      turnScore = addDiceValues(diceValueCount)
      userInputStatement = "Would you like to score the sum of the dice ("+ str(turnScore) +" Points ? [y/n] ::"
    else:
      turnScore = score;
      
    if validateInput(userInputStatement) == 'y':
      totalScore = outputStatements(totalScore, turnScore, turn)
      break
    else:

      if turnScore != addDiceValues(diceValueCount):
        turnScore = addDiceValues(diceValueCount)
        userInputStatement = "Would you like to score the sum of the dice ("+ str(turnScore) +" Points ? [y/n] ::"
        if validateInput(userInputStatement) == 'y':
          totalScore = outputStatements(totalScore, turnScore, turn)
          break
    
      count = count + 1

    if count > 3:
      totalScore = outputStatements(totalScore, turnScore, turn)
      
# Compare total score
if totalScore > 400:
  print("This is a good score")
elif totalScore > 200 and totalScore < 400:
  print("This is an average score")
else:  
  print("Try again!")
