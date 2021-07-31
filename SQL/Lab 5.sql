/*Script: Lab5.sql
Name: Atta UL Saboor
Date: Oct 21st 2020
I, Atta UL Saboor, Student number 000395780, certify that this material is my original work
No other person's work has been used without due acknowledgment and I have not 
made my work available to anyone else.*/

--Make the CHDB database the current database
use CHDB;

--Basic Queries show a count of male patient and average weight of female patients
print 'Group 1 - Query B'

select count(*) from patients 
where gender = 'M'
and patient_weight < (select avg(patient_weight) from patients where gender = 'F')

--Basic quries find the tallest female patient
print 'Group 1 - Query C'

select first_name, last_name, patient_height 
from patients 
where patient_height = (select MAX(patient_height) from patients where gender = 'F') 
and gender = 'F'

--Sub-totals using Group By
print 'Group 2 - Query C'

select province_id, count (patient_id) as province from patients
where province_id != 'ON'
group by province_id

--Sub-totals using Group By
print 'Group 2 - Query D'

select gender, count(patient_id) as height from patients
where patient_height > 175
group by gender

--Two table Joins and Order By
print 'Group 3 - Query C'

select physicians.physician_id, physicians.first_name, physicians.last_name, admissions.nursing_unit_id, admissions.room from physicians 
LEFT join admissions on physicians.physician_id=admissions.patient_id
where specialty = 'Pediatrician'
and admissions.discharge_date IS NULL
order by admissions.nursing_unit_id, admissions.room

--Two table Joins and Order By
print 'Group 3 - Query D'

select departments.department_id, departments.department_name, departments.manager_first_name, departments.manager_last_name, purchase_orders.purchase_order_id, purchase_orders.total_amount  from purchase_orders
left join departments on departments.department_id=purchase_orders.department_id
where purchase_orders.total_amount > 1500
order by departments.department_id DESC;

--Three table Joins
print 'Group 4 - Query A'

select physicians.physician_id, physicians.first_name, physicians.last_name, physicians.specialty from physicians
left join encounters on encounters.physician_id=physicians.physician_id
left join patients on patients.patient_id=encounters.patient_id
where patients.first_name = 'Harry'
and patients.last_name='Sullivan'

--Three table Joins
print 'Group 4 - Query B'

select patients.patient_id, patients.first_name, patients.last_name, nursing_units.nursing_unit_id, admissions.primary_diagnosis from patients
left join admissions on admissions.patient_id=patients.patient_id
left join nursing_units on nursing_units.nursing_unit_id=admissions.nursing_unit_id
where admissions.discharge_date IS NULL
and nursing_units.specialty = 'Internist'

--Four table Joins
print 'Group 5 - Query A'

select physicians.first_name +' '+ physicians.last_name as physician, nursing_units.specialty, patients.first_name +' '+ patients.last_name as patient, admissions.primary_diagnosis from physicians
left join admissions on admissions.attending_physician_id=physicians.physician_id
left join nursing_units on nursing_units.nursing_unit_id=admissions.nursing_unit_id
left join patients on patients.patient_id=admissions.patient_id
where admissions.discharge_date IS NULL
and admissions.secondary_diagnoses IS NULL

--Where [NOT} Exits
print 'Group 6 - Query B'

select purchase_order_id, order_date, department_id from purchase_orders po
where NOT exists (select purchase_order_id from purchase_order_lines where purchase_order_id = po.purchase_order_id);