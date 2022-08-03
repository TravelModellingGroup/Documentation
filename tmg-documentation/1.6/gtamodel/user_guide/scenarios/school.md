# School

Scenario-School contains the information required to assign discrete school zones for students in GTAModel.

Students are broken up into three age-groups in GTAModel.

1. Elementary - 0-13
1. Highschool - 14-17
1. PostSecondary - 18+

> [!Tip]
> In GTAModel V4 input data is organized into the _Scenario folders_ with the following structure,
> _Scenario-Directory_/_RunYear_/_ScenarioName_.

## Contained Files

`V4.0`
* BaseYearStudentLinkages-Elementry.csv
* BaseYearStudentLinkages-Highschool.csv
* BaseYearStudentLinkages-PostSecondary.csv
* ElementaryStudentsByZone2011.csv
* HighschoolStudentsByZone2011.csv
* UniversityStudentsByZone2011.csv

`V4.1+`

* ElementaryStudents.csv `(V4.1 only)`
* ElementaryStudentsLinkages.csv
* HighschoolStudents.csv `(V4.1 only)`
* HighschoolStudentsLinkages.csv
* PostSecondaryStudents.csv `(V4.1 only)`
* PostSecondaryStudentsLinkages.csv

## XStudents.csv

For the `Students.csv` files they contain a vector of two columns household TAZ, and the number of students living in that TAZ
that belong to the age-group.

## XStudentLinkages.csv

For the `XStudentLinkages.csv` files they contain a vector of three columns,
household TAZ, school TAZ, and the number of students that live and go to schools in those TAZ.

> [!Warning]
> If there is no linkages for a household TAZ that has students in the future that
> student will be assigned a school based on the average for the home zone's planning
> district.

## Creating a New Scenario

Creating a new school scenario typically involves copying a scenario and altering the `XLinkages.csv` to apply some
enrolment zone with a new school, or new population.  If you add some new population to a zone that previously had no students
make sure to add some new students to the corresponding `Students.csv` if you are using a GTAModel before 4.2.
