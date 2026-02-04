--Table ZIPCODE_INFO'
alter table ZIPCODE_INFO alter column ZIP_CODE nvarchar(25) not null
alter table ZIPCODE_INFO ADD constraint ZIP_PK primary key (ZIP_CODE)
alter table ZIPCODE_INFO alter column CITY nvarchar(25) not null
alter table ZIPCODE_INFO alter column STATE nvarchar(2) not null

--Table INSTRUCTOR_INFO
alter table INSTRUCTOR_INFO alter column INSTRUCTOR_ID numeric(8,0) not null
alter table INSTRUCTOR_INFO ADD constraint INSTRUCTOR_ID_PK primary key (INSTRUCTOR_ID)
alter table INSTRUCTOR_INFO alter column INSTRUCTOR_FIRST_NAME nvarchar(25) not null
alter table INSTRUCTOR_INFO alter column INSTRUCTOR_LAST_NAME nvarchar(25) not null
alter table INSTRUCTOR_INFO alter column ZIP_CODE nvarchar(25) not null
alter table INSTRUCTOR_INFO Add constraint ZIP_INSTRUCTOR_FK FOREIGN KEY (ZIP_CODE) references ZIPCODE_INFO(ZIP_CODE)

-- Table COURSE_INFO
select * from COURSE_INFO
alter table COURSE_INFO alter column COURSE_NO numeric(8,0) not null
alter table COURSE_INFO add constraint COURSE_NO_PK primary key (COURSE_NO)
alter table COURSE_INFO alter column COURSE_NAME nvarchar(50) not null
alter table COURSE_INFO alter column COST nvarchar(50) not null

--Table STUDENT_INFO
alter table STUDENT_INFO alter column STUDENT_ID numeric(8,0) not null
alter table STUDENT_INFO add constraint STUDENT_ID_PK primary key (STUDENT_ID)
alter table STUDENT_INFO alter column STUDENT_FIRST_NAME nvarchar(25) not null
alter table STUDENT_INFO alter column STUDENT_LAST_NAME nvarchar(25) not null
alter table STUDENT_INFO alter column STUDENT_LAST_NAME nvarchar(25) not null
alter table STUDENT_INFO add constraint ZIP_STUDENT_FK foreign key (ZIP_CODE) references ZIPCODE_INFO(ZIP_CODE)

--Table SECTION_INFO
alter table SECTION_INFO alter column SECTION_ID numeric(8,0) not null
alter table SECTION_INFO add constraint SECTION_ID_PK primary key (SECTION_ID )
alter table SECTION_INFO add constraint COURSE_SECTION_FK foreign key (COURSE_NO) references COURSE_INFO(COURSE_NO)
alter table SECTION_INFO alter column SECTION_NO numeric(3,0) not null
alter table SECTION_INFO add constraint INSTRUCTOR_SECTION_FK foreign key (INSTRUCTOR_ID) references INSTRUCTOR_INFO(INSTRUCTOR_ID)


--Table ENROLLMENT_INFO