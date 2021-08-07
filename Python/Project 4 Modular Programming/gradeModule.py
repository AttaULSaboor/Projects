
#Get Calculate Score
def calculateScore(labPercent, scorePercent):
    score = 0.00
    if (labPercent != -1):
        score = (labPercent/100) * scorePercent
    return score
# Get input from lab Percent
labPercent=int(input("What is your lab percent so far (-1 if no lab yet) ? "))
# Get input from assignment Percent
assignmentPercent=int(input("What is your assignment percent so far (-1 if no assignment yet) ?"))
# Get input from exam percent
examPercent=int(input("What is your exam percent so far (-1 if no exam yet) ? "))
# Calculate the Lab Score
labScore=calculateScore(labPercent, 20)
# Calculate the Exam Score
examScore=calculateScore(examPercent, 70)
# Calculate the Assignment Score
assignmentScore=calculateScore(assignmentPercent, 10)
# Add all the Lab Score, Exam Score and Assignment Score
overallScore=labScore + examScore + assignmentScore
# Total Score
totalScore=0
# Lab Percent Score
if (labPercent != -1):
    totalScore = totalScore + 20
# Exam Percent Score
if (examPercent != -1):
    totalScore = totalScore + 70
# Assignment Percent Score
if (assignmentPercent != -1):
    totalScore = totalScore + 10
#Calculate total marks
marks = round((overallScore / totalScore) * 100, 1);
print("marks::",marks)
#Calculate total Final Grade
finalGrade = ""
if (marks >= 90):
    finalGrade = "A"
elif(marks >= 75 and marks <= 90):
    finalGrade = "B"
elif(marks >= 60 and marks <= 75):
    finalGrade = "C"
elif(marks >= 50 and marks <= 60):
    finalGrade = "D"
else:
    finalGrade = "E"
    
print("if things keep going the way they are you should get a " + str(marks) + " in the course, which is a " +str(finalGrade))
