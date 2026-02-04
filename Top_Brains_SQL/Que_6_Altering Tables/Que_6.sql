

--Table ZIPCODE_INFO
alter table ZIPCODE_INFO alter column CITY nvarchar(25)
alter table ZIPCODE_INFO add STATE nvarchar(2)
select * from ZIPCODE_INFO

--Table INSTRUCTOR_INFO
alter table INSTRUCTOR_INFO alter column INSTRUCTOR_FIRST_NAME nvarchar(25)
alter table INSTRUCTOR_INFO alter column INSTRUCTOR_LAST_NAME nvarchar(25)
alter table INSTRUCTOR_INFO add STREET_ADDRESS nvarchar(50)

-- Table COURSE_INFO
alter table COURSE_INFO add COURSE_NAME nvarchar(50)
alter table COURSE_INFO add COURSE_PREREQUISITE numeric(8,0)
alter table COURSE_INFO alter column COST numeric(9,2)

--Table STUDENT_INFO 
alter table STUDENT_INFO  alter column STUDENT_FIRST_NAME nvarchar(25)
alter table STUDENT_INFO  alter column STUDENT_LAST_NAME nvarchar(25)

alter table STUDENT_INFO  add STREET_ADDRESS nvarchar(50)
alter table STUDENT_INFO  add ZIP_CODE nvarchar(5)


--Table SECTION_INFO 
alter table SECTION_INFO  alter column SECTION_NO numeric(3)
alter table SECTION_INFO  alter column INSTRUCTOR_ID numeric(8)
alter table SECTION_INFO  add LOCATION nvarchar(50)
alter table SECTION_INFO  add CAPACITY numeric(3,0)

--Table ENROLLMENT_INFO
alter table ENROLLMENT_INFO add ENROLLMENT_DATE DATE


--Table GRADE_INFO 
alter table GRADE_INFO alter column GRADE_CODE_OCCURANCE numeric(38,0)
alter table GRADE_INFO add NUMERIC_GRADE numeric (3,0)



