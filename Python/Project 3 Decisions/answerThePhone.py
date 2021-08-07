
sleep = input ("Are you asleep?")

display_message=""

if sleep == "yes":
    display_message="user will not answer the phone"
elif sleep == "no":
    mom = input ("Is it your mom calling?")
    if mom == "yes":
        display_message="user will answer the phone"
    elif mom == "no":
        morning = input ("Is it morning?")
        if morning == "yes":
            display_message="user will not answer the phone"
        elif morning == "no":
            display_message="user will answer the phone"
print (display_message)

        




