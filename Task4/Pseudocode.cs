// Task 4 ##
// Shipping Rates ###

//setup
var inputpounds = 0
var shippingrate=0
var firstlevel=2
var firstcost = 2
var secondlevel = 4
var secondcost = 4
    var thridlevel = 6
    var thirdcost = 6
var fourthlevel = 10
var fourthcost = 8
var tempnum = string.Empty;

//input

do
    inputpounds = "What is the weight of your package"    
    tempnum = GET console.readline


    if int.tryparse.tempnum = false && tempnum > 0
        PUT "Please input a number GT 0"
while tempnum is not numeric && tempnum > 0
inputpounds = int.Parse tempnum

//processing
if inputpounds <= firstlevel 
    shippingrate = firstcost
else if inputpounts < secondlevel
    shippingrate = secondlcost
else if inputpounds <= thirdlevel>
    shippingrate = thirdcost
else
    shippingrate = fourthcost


//output
PUT "The shipping cost is " + shippingcost

