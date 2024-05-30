CREATE TABLE Customers (
    CustomerID varchar2(20)  Primary Key,
    CustomerName varchar2(50),
    Phone varchar2(11),
    Address varchar2(100),
        CONSTRAINT check_CustomersPhone_format
    CHECK (REGEXP_LIKE(Phone, '^01[0-9]{9}'))
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR2(100),
    Position VARCHAR2(50),
    Salary Number(10,2),
    Phone varchar2(11),
    CONSTRAINT check_EmployeesPhone_format
    CHECK (REGEXP_LIKE(Phone, '^01[0-9]{9}'))
);

CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY,
    Name VARCHAR2(100),
   Phone varchar2(11),
    Address VARCHAR2(100),
    CONSTRAINT check_SuppliersPhone_format
    CHECK (REGEXP_LIKE(Phone, '^01[0-9]{9}'))
);

CREATE TABLE Inventory (
    ItemName VARCHAR2(100),
    Category VARCHAR2(50),
    Quantity NUMBER,
    PricePerUnit DECIMAL(10, 2),
    SupplierID NUMBER,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);

CREATE TABLE MenuItems (
    MenuItemID NUMBER PRIMARY KEY,
    Name VARCHAR2(100),
    Description varchar2(255),
    Price Number,
    Category VARCHAR2(50)
);

CREATE TABLE Orders (
    OrderID NUMBER PRIMARY KEY,
    CustomerID varchar2(20) ,
    OrderDate Date,
    TotalAmount DECIMAL(10, 2),
    Status VARCHAR2(50),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails (
    OrderDetailID NUMBER PRIMARY KEY,
    OrderID NUMBER,
    MenuItemID NUMBER,
    Quantity NUMBER,
    TotalPrice NUMBER,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (MenuItemID) REFERENCES MenuItems(MenuItemID)
);
Create Table Payment
(
    PaymentID NUMBER Primary Key ,
    OrderID NUMBER,
    TotalPayment NUMBER,
    PaymentMethod varchar2(20)
);
CREATE TABLE Reservations (
    ReservationID NUMBER PRIMARY KEY,
    CustomerID varchar2(20),
    ReservationDate Date,
    NumberOfPeople NUMBER,
    TableNumber NUMBER,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE Tables (
    TableNumber NUMBER,
    SeatingCapacity NUMBER,
    Location VARCHAR2(100)
);


--Customer ID Generation
--we will need a sequence ,trigger and function

CREATE SEQUENCE seq_CustomerID
minvalue 1
maxvalue 99999
start with 1;

CREATE or REPLACE FUNCTION CustomerIDGenerator(p_Phone IN varchar2) return varchar2 as
v_CID Customers.CustomerID%type :='C';
begin
    v_CID:=v_CID||TO_CHAR(SYSDATE,'YY')||TO_CHAR(SYSDATE,'DD')||SUBSTR(p_Phone,-4,4)||LPAD(seq_CustomerID.nextval,3,0);
    return v_CID;
end;
/

CREATE or REPLACE Trigger tr_CustomerIDGen
before INSERT on Customers
for each row
begin
    :new.CustomerID:=CustomerIDGenerator(:new.Phone);
end;
/
-- INSERT INTO Customers (CustomerName, Phone, Address)
-- VALUES ('John Doe', '01234567890', '123 Main St');