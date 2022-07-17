# L0---Generic-Penalty-Calculation---Assignment---V3.0
L0 - Generic Penalty Calculation - Assignment - V3.0

In this assignment you are expected to develop a generic function to calculate penalty for late returned 
books for a library system.
Requirements
1) The library function should make usage of:
a. Date start, -- this is the date penalty calculation should start. Inclusive.
b. Date end, -- this is the date penalty calculation should finish. Inclusive.
c. Country of operation.
2) The library function should return
a. Calculated penalty
3) Penalty should be calculated for BUSINESS days only. That means your calculation should take 
account of weekends and national holidays. 
4) You should develop your own algorithm for business day count. 
a. Hint: Try to use DayOfWeek enumeration of .Net
5) Each late business day will be penalized for x amount of money. This amount should be 
configurable based on country of operation. (DailyPenaltyFee parameter in App.config)
6) Penalty will not apply for an allowed amount of days (PenaltyAppliesAfter parameter in 
App.config)
# Notes
1) You will develop this function in a ready to run solution environment, so take some time to 
think thoroughly before building the solution.
2) The solution consists of two projects, LibraryApplication and LibraryBusiness. You can run this 
application simply by selecting LibraryApplication project as “Startup Project” of the solution 
(if it is already not) and entering command line arguments as you like.(to set command line 
arguments; right click LibraryApplication select Properties, in main panel select Debug on the 
left menu, you will see command line arguments under Start options.)
3) LibraryApplication is a simple DOS based interface which is used to test library business 
project. There are two necessary files you should understand well, App.config and Program.cs. 
As usually Program.cs file is where main() method is in. Now please open program.cs file and 
find comment block starting with Description in the main() method. App.config file contains 
necessary configuration parameters which will help you to accomplish requirements given 
below. Please open App.config file and and find comment starting with Description
4) LibraryBusiness project is where whole business logic resides. The most important file for this
application is PenaltyFeeCalculator.cs, and you are required to implement this class. Please 
open this file and find Description comment. Other files in this class does not require any 
modification, therefore you should better just focus on the PenaltyFeeCalculator.
18.03.2022
2
5) DO NOT try to parse the configuration file. It is already parsed; “settingList” variable in 
PenaltyCalculator class and contains all necessary configurations which already read the 
values from app.config file in startup.
6) Your solution should handle error cases like invalid date time input or when the end date is 
less than start date or when you can’t find any configuration value for the country.
7) Please try to construct best solution you can and make an example of good programming 
practices both in structure and syntax. Write appropriate comments also.
# Instructions
1) You have two hours to complete this test. Any submission after this will not be accepted.
2) After completing we kindly request you to send us back the whole solution.
3) Please archive all the above files in one .zip or .rar file and name it with your name.
4) Please ask any questions if you have any doubt about the requirements
