CREATE TABLE Sales (
    product_id int,
    employee_id int,
    quantity_sold int,
    sale_date varchar(255),
	PRIMARY KEY (product_id, employee_id)
);

CREATE TABLE Employees (
    employee_id int primary key identity(1,1),
    name varchar(50),
    position varchar(50),
	wage int
);

CREATE TABLE Products (
    product_id int primary key identity(1,1),
    name varchar(50),
    category varchar(50),
	price int,
	weight float,
	stock_quantity int
);

