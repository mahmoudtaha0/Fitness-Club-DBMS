
-------------Database creation-------------
CREATE DATABASE Gym
GO
USE Gym

------------Table Creation-----------------
CREATE TABLE People (
	
	ssn				VARCHAR(14),
	person_name		VARCHAR(50) NOT NULL,
	person_address	VARCHAR(50) NOT NULL,
	gender			VARCHAR(10) NOT NULL,
	phone_number	VARCHAR(15) NOT NULL,  -- mostly begins with 01x, may begin with +20 for example
	birth_date		DATE NOT NULL,

	Primary key (ssn)

)

CREATE TABLE Managers (
	
	ssn			VARCHAR(14),
	email		VARCHAR(50) NOT NULL,
	password	VARCHAR(50) NOT NULL,

	Primary key (ssn),

	FOREIGN KEY (ssn) REFERENCES People (ssn)

)

CREATE TABLE Programs (

	id				INT,
	name			VARCHAR(50) NOT NULL,
	description		VARCHAR(50) NOT NULL,
	price			INT NOT NULL,
	number_of_weeks INT NOT NULL,

	Primary key (id)

)

CREATE TABLE Memberships (

	id					INT,
	membership_name		VARCHAR(50) NOT NULL,
	price				INT,
	duration			INT, -- In months

	Primary key (id)

)

CREATE TABLE Employees (
	
	ssn				VARCHAR(14),
	-- Relationships attributes
	manager_ssn		VARCHAR(14),

	Primary key (ssn),

	CONSTRAINT emp_people FOREIGN KEY (ssn) REFERENCES People (ssn),

	CONSTRAINT emp_manager FOREIGN KEY (manager_ssn) REFERENCES Managers (ssn)
	ON UPDATE	CASCADE
	ON DELETE	SET NULL

)
--go
--create trigger tg_mananger_update on Managers instead of UPDATE
--as
--begin
--  set nocount on;
--  update Managers set ssn = null where ssn in (select People.ssn from deleted);
--  delete from Managers where UserId in (select UserID from deleted);
--end

CREATE TABLE Trainers (
	
	ssn		VARCHAR(14),

	-- Multivalued attribute in trainers_certificates table
	
	Primary key (ssn),

	FOREIGN KEY (ssn) REFERENCES Employees (ssn)

)

CREATE TABLE trainers_certificates (
	
	ssn					VARCHAR(14),
	certificates_name	VARCHAR(50),
	
	Primary key (ssn, certificates_name),

	FOREIGN KEY (ssn) REFERENCES Trainers (ssn)
	ON UPDATE	CASCADE
	ON DELETE	CASCADE

)

CREATE TABLE Receptionists (
	
	ssn				VARCHAR(14),
	email			VARCHAR(50) NOT NULL,
	password		VARCHAR(50) NOT NULL,
	-- Relationships attributes
	
	-- Multivalued attribute in receptionists_skills table

	Primary key (ssn),

	FOREIGN KEY (ssn) REFERENCES Employees (ssn)


)

CREATE TABLE receptionists_skills (
	
	ssn				VARCHAR(14),
	skill			VARCHAR(50),
	
	Primary key (ssn, skill),

	FOREIGN KEY (ssn) REFERENCES Receptionists (ssn)
	ON UPDATE	CASCADE
	ON DELETE	CASCADE

)

CREATE TABLE Trainees (
	
	ssn				VARCHAR(14),
	sub_start_date	DATE NOT NULL,
	sub_end_date	DATE NOT NULL,

	-- relationships attributes
	program_id		INT,
	membership_id	INT,
	trainer_ssn		VARCHAR(14),

	Primary key (ssn),

	FOREIGN KEY (ssn) REFERENCES People (ssn)
	ON UPDATE	CASCADE
	ON DELETE	CASCADE,

	FOREIGN KEY (program_id)	REFERENCES Programs (id)
	ON UPDATE	CASCADE
	ON DELETE	SET NULL,


	FOREIGN KEY (membership_id)	REFERENCES Memberships (id)
	ON UPDATE	CASCADE
	ON DELETE	SET NULL,


	FOREIGN KEY (trainer_ssn)	REFERENCES Trainers (ssn)
	ON UPDATE	CASCADE
	ON DELETE	SET NULL

)

CREATE TABLE Devices (

	id					INT,
	device_name			VARCHAR(50) NOT NULL,
	manufacturer_name	VARCHAR(50) NOT NULL,
	muscle_group		VARCHAR(50) NOT NULL,
	date_of_purchase	DATE NOT NULL,
 
	Primary key (id)

)

CREATE TABLE Lockers (

	number			INT,
	price_per_month INT NOT NULL,
	
	-- Relationship attributes
	trainee_ssn		VARCHAR(14),

	Primary key (number),
	FOREIGN KEY (trainee_ssn)	REFERENCES	Trainees (ssn)
	ON UPDATE	CASCADE
	ON DELETE	SET NULL,

)

CREATE TABLE Salary (

	-- salary of each employee each month
	employee_ssn		VARCHAR(14),
	salary_date			DATE NOT NULL,
	gross_salary		INT NOT NULL,
	taxes_percentage	INT NOT NULL,
	bonus				INT NOT NULL,
	penality			INT NOT NULL,
	
	Primary key (employee_ssn, salary_date),

	FOREIGN KEY (employee_ssn) REFERENCES Employees (ssn)
	ON UPDATE	CASCADE
	ON DELETE	CASCADE

)

CREATE TABLE Attendance (

	employee_ssn		VARCHAR(14),
	attendance_date		DATE NOT NULL,
	attendance_type		VARCHAR(50) NOT NULL,  -- Attended, Absent, Early, Late
	
	Primary key (employee_ssn, attendance_date),

	FOREIGN KEY (employee_ssn) REFERENCES Employees (ssn)
	ON UPDATE	CASCADE
	ON DELETE	CASCADE

)

CREATE TABLE Holidays (

	employee_ssn		VARCHAR(14),
	start_date			DATE,
	end_date			DATE,
	request_status		VARCHAR(50) NOT NULL, -- Accepted, Rejected, Pending
	
	Primary key (employee_ssn, start_date, end_date),

	FOREIGN KEY (employee_ssn) REFERENCES Employees (ssn)
	ON UPDATE	CASCADE
	ON DELETE	CASCADE

)

CREATE TABLE Invitations (

	trainee_ssn		VARCHAR(14),
	client_name		VARCHAR(50) NOT NULL,
	phone_number	VARCHAR(15) NOT NULL,  -- mostly begins with 01x, may begin with +20 for example

	Primary key (trainee_ssn),
	FOREIGN KEY (trainee_ssn)	REFERENCES Trainees (ssn)
	ON UPDATE	CASCADE
	ON DELETE	CASCADE

)

CREATE TABLE Transactions (

	id				INT,
	person_ssn		VARCHAR(14),
	t_date			DATE NOT NULL,
	amount			INT NOT NULL,
	type			VARCHAR(50) NOT NULL,	-- Withdraw/deposit
	description		VARCHAR(50) NOT NULL,	-- Salary, Subscription, Locker, Managers withdraw


	PRIMARY KEY (id),
	FOREIGN KEY (person_ssn) REFERENCES People (ssn)
	ON UPDATE	CASCADE
	ON DELETE	SET NULL

)

CREATE TABLE specialize_in (

	device_id		INT,
	trainer_ssn		VARCHAR(14),


	PRIMARY KEY (device_id, trainer_ssn),
	FOREIGN KEY (trainer_ssn) REFERENCES Trainers (ssn)
	ON UPDATE	CASCADE
	ON DELETE	CASCADE,		-- alshan mesh m7tagin n3dl 3ala el null value, keda keda hanhot row gedid w khlas

	FOREIGN KEY (device_id) REFERENCES Devices (id)
	ON UPDATE	CASCADE
	ON DELETE	CASCADE

)
