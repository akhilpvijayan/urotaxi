USE [Taxeei]
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'GetBookingDetails')
DROP PROCEDURE [GetBookingDetails]

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetBookingDetails]
	 @carModelId INT
        AS
        BEGIN
		    DECLARE @sqlQuery nvarchar(max)
            SET NOCOUNT ON;
								select 
								CM.CarModelId carModelId,
								CM.CarModel carModel,
								CM.carType carTypeId,
								CASE WHEN CM.isAC = 1 THEN 'AC' ELSE 'Non-AC' END AS isAC,
								CM.seats seats,
								CM.minFare fare,
								CM.carImage carImage, 
								(SELECT carType FROM CarTypes CT WHERE CT.carTypeId = CM.carType) carType,
								(SELECT fuelType FROM FuelTypes FT WHERE FT.fuelTypeId = CM.fuelType) fuelType,
								(SELECT driverId FROM Drivers D WHERE D.carModel = carModelId) driverId,
								(SELECT driverName FROM Drivers D WHERE D.carModel = carModelId) driverName,
								(SELECT driverEMail FROM Drivers D WHERE D.carModel = carModelId) driverEMail,
								(SELECT driverPhone FROM Drivers D WHERE D.carModel = carModelId) driverPhone
								FROM CarModels CM WHERE CM.carModelId = @carModelId
								
        END
GO

EXEC GetBookingDetails 4