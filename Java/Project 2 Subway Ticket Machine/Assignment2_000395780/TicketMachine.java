/*
This class is used as model for Subway Ticket Machine.I Completed 28, Jan, 2020
author Atta UL Saboor
 */
package Assignment2_000395780;
public class TicketMachine {
    String selectedRoute = "Uptown";
    int child = 0;
    int adult = 0;
    double credit = 0.00;
    double totalAmount = 0.00;
    String machine = "";
     //Print output
    public String toString() {
        return "\n" + "-------------------------------------------------------- \n"+
                " Selected Route:"+ this.selectedRoute +"  Child: $2.50   Adult: $5.00 \n"+
                "Children: "+ this.child +"   Adults: "+ this.adult + "\n"+
                "Credit: $" + this.credit + " \n"+
                "--------------------------------------------------------";
    }
    public void childrenAdd() { this.child++; }
    public void childrenLess() { this.child--; }
    public void adultAdd() { this.adult++; }
    public void adultLess() { this.adult--; }
    public void insertQuarter(){ credit = credit + 0.25;}
    public void insertLoonie(){ credit = credit + 1;}
    public void insertToonie(){ credit = credit + 2;}
     //Set first route
    public void firstRoute() {
        if (this.machine.equals("First Machine")){
            this.selectedRoute = "Uptown";
        } else {
            this.selectedRoute = "Upper WenthWorth.";
        }
    }
     //Set second route
    public void secondRoute() {
        if (this.machine.equals("Second Machine")){
            this.selectedRoute = "Downtown";
        } else {
            this.selectedRoute = "Ottawa St.";
        }
    }
    //Check print ticket
    public boolean printTicket(){
        getTotalAmount();
        if(this.totalAmount == this.credit){
            return true;
        }
        return false;
    }
     //Calculate the Ticket Amount according to number of child and adult
    public void getTotalAmount(){
        totalAmount = (this.child * 2.50) + (this.adult * 5.00);
    }
}

