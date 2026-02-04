--Table ZIPCODE_INFO
create table ZIPCODE_INFO
(ZIP_CODE NVARCHAR(5),
CITY NVARCHAR(5))

--Table INSTRUCTOR_INFO
create table INSTRUCTOR_INFO
(INSTRUCTOR_ID numeric (8,0),
INSTRUCTOR_FIRST_NAME nvarchar(15),
INSTRUCTOR_LAST_NAME nvarchar(15))

-- Table COURSE_INFO
create table COURSE_INFO
( COURSE_NO numeric (8,0),
Cost numeric (8,0))

--Table STUDENT_INFO
create table STUDENT_INFO
(STUDENT_ID numeric (8,0),
STUDENT_FIRST_NAME nvarchar(15),
STUDENT_LAST_NAME nvarchar(15))

--Table SECTION_INFO
create table SECTION_INFO
(SECTION_ID numeric (8,0),
COURSE_NO numeric (8,0),
SECTION_NO numeric (5),
INSTRUCTOR_ID numeric (8,0))

--Table ENROLLMENT_INFO
create table ENROLLMENT_INFO
(STUDENT_ID numeric (8,0),
SECTION_ID numeric (8,0))

--Table GRADE_INFO
create table GRADE_INFO
(STUDENT_ID numeric (8,0),
SECTION_ID numeric (8,0),
GRADE_TYPE_CODE nvarchar(2),
GRADE_CODE_OCCURANCE numeric (5))
