#I, Atta UL Saboor, student number 000395780, certify that all code submitted is my
#own work, that I have cot copied it from any other source. I also certify that I
#have not allowed my work to be copied by others.


#user will enter a string any character
user_input= str(input("please enter a string character :"))

#calculate the length of character
string_length = len(user_input)

#print string even or odd
print("The input length is even:",string_length % 2 == 0)

#print user_input starting length
print("The starting length:", string_length)

#Get the user input h1,div,or article
tag = input(" Enter either hi, div, or article :")
midpoint = round(string_length / 2)
print(midpoint)
first_half =str(user_input[0:midpoint])

#calculate coneatenation tag
tagged_input = "<" + tag + ">" + first_half + "</" + tag + ">"

#calculate the length of tagged_input
tag_length=len(tagged_input)

#caculating the new string spaces_needed
spaces_needed=(80-tag_length)//2

#printing the result
print(tagged_input .rjust(spaces_needed))





