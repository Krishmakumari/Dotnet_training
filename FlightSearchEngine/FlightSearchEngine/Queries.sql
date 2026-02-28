CREATE DATABASE FlightSearchEngineDB;

Use FlightSearchEngineDB

CREATE TABLE Flights (
    FlightId INT PRIMARY KEY IDENTITY(1,1),
    FlightName NVARCHAR(100) NOT NULL,
    FlightType NVARCHAR(50) NOT NULL,
    Source NVARCHAR(100) NOT NULL,
    Destination NVARCHAR(100) NOT NULL,
    PricePerSeat DECIMAL(18,2) NOT NULL
);

CREATE TABLE Hotels (
    HotelId INT PRIMARY KEY IDENTITY(1,1),
    HotelName NVARCHAR(100) NOT NULL,
    HotelType NVARCHAR(50) NOT NULL,
    Location NVARCHAR(100) NOT NULL,
    PricePerDay DECIMAL(18,2) NOT NULL
);


INSERT INTO Flights VALUES
('IndiGo 101', 'Domestic', 'Delhi', 'Mumbai', 5000),
('Air India 202', 'Domestic', 'Delhi', 'Bangalore', 6000),
('Emirates 303', 'International', 'Delhi', 'Dubai', 25000);

INSERT INTO Hotels VALUES
('Taj Mumbai', '5 Star', 'Mumbai', 7000),
('Leela Bangalore', '5 Star', 'Bangalore', 6500),
('Atlantis Dubai', 'Luxury', 'Dubai', 15000);


--storded procedures
CREATE PROCEDURE sp_GetSources
AS
BEGIN
    SELECT DISTINCT Source FROM Flights;
END


CREATE PROCEDURE sp_GetDestinations
AS
BEGIN
    SELECT DISTINCT Destination FROM Flights;
END




CREATE PROCEDURE sp_SearchFlights
    @Source NVARCHAR(100),
    @Destination NVARCHAR(100),
    @Persons INT
AS
BEGIN
    SELECT 
        FlightId,
        FlightName,
        FlightType,
        Source,
        Destination,
        (PricePerSeat * @Persons) AS TotalCost
    FROM Flights
    WHERE Source = @Source
      AND Destination = @Destination;
END




CREATE PROCEDURE sp_SearchFlightsWithHotels
    @Source NVARCHAR(100),
    @Destination NVARCHAR(100),
    @Persons INT
AS
BEGIN
    SELECT 
        f.FlightId,
        f.FlightName,
        f.Source,
        f.Destination,
        h.HotelName,
        ((f.PricePerSeat * @Persons) + h.PricePerDay) AS TotalCost
    FROM Flights f
    INNER JOIN Hotels h
        ON f.Destination = h.Location
    WHERE f.Source = @Source
      AND f.Destination = @Destination;
END


INSERT INTO Flights (FlightName, FlightType, Source, Destination, PricePerSeat)
VALUES
-- Delhi → Mumbai
('IndiGo 101', 'Domestic', 'Delhi', 'Mumbai', 5000),
('Air India 102', 'Domestic', 'Delhi', 'Mumbai', 5500),

-- Delhi → Bangalore
('SpiceJet 201', 'Domestic', 'Delhi', 'Bangalore', 6000),
('Vistara 202', 'Domestic', 'Delhi', 'Bangalore', 6200),

-- Delhi → Dubai
('Emirates 303', 'International', 'Delhi', 'Dubai', 25000),
('FlyDubai 304', 'International', 'Delhi', 'Dubai', 22000),

-- Mumbai → Dubai
('Air India 401', 'International', 'Mumbai', 'Dubai', 24000),

-- Bangalore → London
('British Airways 501', 'International', 'Bangalore', 'London', 45000);



INSERT INTO Hotels (HotelName, HotelType, Location, PricePerDay)
VALUES
-- Mumbai hotels
('Taj Mumbai', '5 Star', 'Mumbai', 7000),
('Trident Mumbai', '5 Star', 'Mumbai', 6500),

-- Bangalore hotels
('Leela Bangalore', '5 Star', 'Bangalore', 6500),
('ITC Gardenia', '5 Star', 'Bangalore', 6000),

-- Dubai hotels
('Atlantis Dubai', 'Luxury', 'Dubai', 15000),
('Burj Al Arab', 'Luxury', 'Dubai', 18000),

-- London hotels
('Royal London Inn', '5 Star', 'London', 8000),
('Thames View Hotel', '5 Star', 'London', 7500);