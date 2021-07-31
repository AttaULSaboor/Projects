/** 
Name:Atta UL Saboor 
Date: 13 November, 2020
Description: I make a simple general knowledge quiz. First form for student
registration. In this form ask from user name, age and favorite colors and 
use in the quiz. Display result in the show result. 
**/

window.addEventListener("load", function() {

    // hide the quiz
    let container1 = document.getElementById("container1");
    container1.style.display = 'none';

    // hide the show result
    let container2 = document.getElementById("container2");
        container2.style.display = 'none';

    document.forms.registration_form.addEventListener("submit", function(event){
        event.preventDefault();
        
        let studentid = document.forms.registration_form.studentid.value;
        let age = document.forms.registration_form.age.value;
        let color = document.forms.registration_form.color.value;

        // display the quiz
        container1.style.display = 'block';

        // hide the form
        let container = document.getElementById("container");
        container.style.display = 'none';

        // show name, age and color in quiz
        document.getElementById("displayName").innerHTML = "<h2>Welcome " + studentid + "</h2>";
        document.getElementById("displayAge").innerHTML = "<h2>Age: " + age + "</h2>";
        document.getElementById("displayColor").innerHTML = "<h2>Favorite Color: " + color + "</h2>";
    });

    document.forms.registration_form1.addEventListener("submit", function(event){
        event.preventDefault();

        let q1 = document.querySelector('input[name="q1"]:checked').value;
        let q2 = document.querySelector('input[name="q2"]:checked').value;
        let q3 = document.querySelector('input[name="q3"]:checked').value;
        let q4 = document.querySelector('input[name="q4"]:checked').value;
        let q5 = document.querySelector('input[name="q5"]:checked').value;

        let a1 = false;
        let a2 = false;
        let a3 = false;
        let a4 = false;
        let a5 = false;
        
        if(q1 === "ottawa"){
            a1 = true;
        }
        if(q2 == "english and french") {
            a2 = true;
        }
        if(q3 == "maple leaf") {
            a3 = true;
        }
        if(q4 == "beaver") {
            a4 = true;
        }
        if(q5 == "russia") {
            a5 = true;
        }

        // display result in show result
        document.getElementById("q1").innerHTML = "<h3>Question 1: " + a1 + "</h3>";
        document.getElementById("q2").innerHTML = "<h3>Question 2: " + a2 + "</h3>";
        document.getElementById("q3").innerHTML = "<h3>Question 3: " + a3 + "</h3>";
        document.getElementById("q4").innerHTML = "<h3>Question 4: " + a4 + "</h3>";
        document.getElementById("q5").innerHTML = "<h3>Question 5: " + a5 + "</h3>";

         // display the show result
         container2.style.display = 'block';

         // hide the quiz
         let container1 = document.getElementById("container1");
         container1.style.display = 'none';
 
    });

    document.forms.registration_form2.addEventListener("submit", function(event){
        event.preventDefault();

        // display the registration form
        container.style.display = 'block';

        // hide the show result
        let container2 = document.getElementById("container2");
        container2.style.display = 'none';

    });
});
