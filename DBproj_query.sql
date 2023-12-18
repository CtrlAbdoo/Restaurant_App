-- Database and tables creation
create database rest_DBS;
use rest_DBS

create table customers(
	cid int primary key identity(1, 1),
	fname varchar(30) not null,
	lname varchar(30) not null,
	email varchar(30) unique not null,
	pword varchar(30) not null,
	phone varchar(11) unique not null
);

create table employees(
	eid int primary key identity(1, 1),
	fname varchar(30) not null,
	lname varchar(30) not null,
	salary int not null,
	phone varchar(11) unique not null
);

create table vehicles(
	vid int primary key identity(1, 1),
	plate_num varchar(7) unique not null,
	status varchar(30) not null,

	eid int foreign key references employees(eid) on update cascade on delete cascade
);

create table orders(
	oid int primary key identity(1, 1),
	odate date not null,
	oadress varchar(50) not null,
	cost int not null,

	eid int foreign key references employees(eid) on update cascade on delete cascade,
	cid int foreign key references customers(cid) on update cascade on delete cascade
);

create table products(
	pid int primary key identity(1, 1),
	pname varchar(30) unique not null,
	price int not null
);

create table orders_content(
	pid int,
	oid int,
	quantity int not null,
	primary key(pid, oid),

	foreign key (pid) references products(pid),
	foreign key (oid) references orders(oid)
);


-- insert statements
insert into customers(fname,lname,email,phone)
values('abdoo','ashraf','a.Ashraf112@gmail.com','01014147214'),
	  ('abdullah','eldaliy','a.Eldaliy.com','01012951616'),
	  ('abdo','ashraff','ashraffs2321@gmail.com','01016411366');


insert into employees (fname, lname,salary,phone)
values('abdoo','ashraf',152300,'01014147214'),
	  ('abdullah','eldaliy',133200,'01012951616'),
	  ('abdo','ashraff',41450,'01016411366');  

insert into vehicles(plate_num, status, eid)
values('25342','functional', 5),
	  ('55342','broken down', 2),
	  ('92553','functional', 8),
	  ('45342','functional',1),
	  ('85456','functional',4);

insert into products(pname, price)
values('Raffles Seychelles Salad', 25),
	  ('Chiken Caesar Salad', 30),
	  ('Beef Shish Kebab', 120),
	  ('Chicken Shish Kebab', 120),
	  ('Ribeye Steak', 150),
	  ('Double Chocolate', 40),
	  ('Pineapple & Banana Delice', 70);

--select statements 
select * from employees;
select * from customers;
select * from vehicles;
select * from products;
select * from orders;
select * from orders_content;


select * from employees
inner join 
