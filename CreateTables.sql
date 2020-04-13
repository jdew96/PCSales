CREATE DATABASE PcSalesInventory

CREATE TABLE SystemsForSale(
    SystemId int IDENTITY(1,1) PRIMARY KEY, 
    Price FLOAT NOT NULL,
    SystemName VARCHAR(255) NOT NULL,
    InventoryCount INT NOT NULL,
);

CREATE TABLE SystemToPart(
    PartId INT NOT NULL,
    PartTypeId INT NOT NULL,
    PartNum INT NOT NULL,
    SystemId INT NOT NULL
    PRIMARY KEY(PartId)
    FOREIGN KEY(SystemId) REFERENCES SystemsForSale(SystemId)
);

CREATE TABLE Spec(
    PartNum INT NOT NULL,
    PartName varchar(255) NOT NULL,
    Manufacturer varchar(255) NOT NULL,
);

CREATE TABLE CpuSpec(
    PartNum INT NOT NULL,
    PartName varchar(255) NOT NULL,
    Manufacturer varchar(255) NOT NULL,
    CoresCount int not null,
    TDP int not null,
    Socket varchar(255) not null,
    ClockSpeed float not null
);

CREATE TABLE MoboSpec(
    PartNum INT NOT NULL,
    PartName varchar(255) NOT NULL,
    Manufacturer varchar(255) NOT NULL,
    FormFactor varchar(255) not null,
    SataSlots int not null,
    Socket varchar(255) not null,
    MemoryMax int not null,
    MemoryType varchar(255) not null,
    MemorySlots int not null,
    M2Slots int not null
);

CREATE TABLE RamSpec(
    PartNum INT NOT NULL,
    PartName varchar(255) NOT NULL,
    Manufacturer varchar(255) NOT NULL,
    MemoryType varchar(255) not null,
    MemoryModules int not null,
    MemoryTotal int not null,
    ClockSpeed float not null
);

CREATE TABLE CaseSpec(
    PartNum INT NOT NULL,
    PartName varchar(255) NOT NULL,
    Manufacturer varchar(255) NOT NULL,
    FormFactor varchar(255) not null
);

CREATE TABLE GpuSpec(
    PartNum INT NOT NULL,
    PartName varchar(255) NOT NULL,
    Manufacturer varchar(255) NOT NULL,
    VRAM int not null,
    ClockSpeed float not null,
    ChipSet varchar(255) not null,
    MemoryType varchar(255) not null,
    TDP int not null
);

CREATE TABLE PsuSpec(
    PartNum INT NOT NULL,
    PartName varchar(255) NOT NULL,
    Manufacturer varchar(255) NOT NULL,
    Wattage int not null,
    Modular bit not null,
    EfficiencyRating varchar(255) not null,
    FormFactor varchar(255) not null
);

CREATE TABLE StorageSpec(
    PartNum INT NOT NULL,
    PartName varchar(255) NOT NULL,
    Manufacturer varchar(255) NOT NULL,
    Interface varchar(255) not null,
    Capacity int not null,
    Type varchar(255) not null
);