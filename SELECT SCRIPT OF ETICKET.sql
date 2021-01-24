--Masters-------------------------
SELECT * FROM dbo.Eticket_LKP_Quota
SELECT * FROM dbo.ETicket_LKP_User_Type
SELECT * FROM dbo.Eticket_MST_BUS_DESC
SELECT * FROM dbo.Eticket_MST_Location
SELECT * FROM dbo.Eticket_MST_Operators
SELECT * FROM dbo.Eticket_MST_Operators
SELECT * FROM dbo.Eticket_MST_Route_Name
SELECT * FROM dbo.Eticket_TicketType
SELECT * FROM dbo.Eticket_BUS_FARE
SELECT * FROM dbo.Eticket_LKP_Gender
SELECT * FROM dbo.Eticket_LKP_OperatorType
SELECT * FROM dbo.Eticket_LKP_PaymentMode
SELECT * FROM dbo.Eticket_TransactionType
SELECT * FROM dbo.Eticket_MST_BUS_DESC

-----Transactions----

SELECT * FROM dbo.ETicket_User_Acounts
SELECT * FROM dbo.Eticket_PaymentDetails
SELECT * FROM dbo.Eticket_PassengerDetails
SELECT * FROM dbo.Eticket_BookingDetails
SELECT * FROM dbo.Eticket_Agent_History
SELECT * FROM dbo.Eticket_Bus_ActiveOnDates_Status
SELECT * FROM dbo.Eticket_MST_BUS_DESC
SELECT * FROM dbo.Eticket_MAP_BUS_SEAT where UserType=2 and Bus_ID=1
SELECT * FROM dbo.ETicket_BUS_ROUTE_LOCATION
SELECT * FROM dbo.Eticket_Bus_ActiveOnDates_Status
 
---------DELETE SCRIPT OF REQUIRED TABLES------------
--DELETE FROM dbo.Eticket_MST_Route_Name
--DELETE FROM dbo.Eticket_MST_BUS_DESC
--DELETE FROM dbo.Eticket_BUS_FARE
--DELETE FROM dbo.Eticket_Agent_History
--DELETE FROM dbo.Eticket_PaymentDetails
--DELETE FROM dbo.Eticket_PassengerDetails
--DELETE FROM dbo.Eticket_BookingDetails
--DELETE FROM dbo.Eticket_Bus_ActiveOnDates_Status
--DELETE FROM dbo.ETicket_BUS_ROUTE_LOCATION
--DELETE FROM dbo.Eticket_MAP_BUS_SEAT
--DELETE FROM Eticket_MST_Operators
--DELETE FROM dbo.ETicket_User_Acounts WHERE UserTypeID IN(1,2)

--------------Dont DELETE -------------------------------------
--  dbo.Eticket_MST_Location
--  dbo.Eticket_MST_Location_Map
--  dbo.Eticket_TicketType
--  dbo.Eticket_TransactionType
--  dbo.Eticket_LKP_PaymentMode 
--  dbo.Eticket_LKP_OperatorType
--  dbo.Eticket_LKP_Gender
--  dbo.Eticket_LKP_Quota
--  dbo.ETicket_LKP_User_Type
---------------------------------------------------------


--------SCRIPT TO FREE ALL BUS SEATS
----UPDATE dbo.Eticket_MAP_BUS_SEAT
--SET SeatUrl='~/Images/UnAllocatedSeat.png',IsActive=0 WHERE UserType=1

--UPDATE dbo.Eticket_MAP_BUS_SEAT 
--SET SeatUrl='~/Images/OtherAreaSeats.png',IsActive=0 WHERE UserType=2  

------------------------------------------------------------

--JOBS
--UPDATE Eticket_MAP_BUS_SEAT SET SeatUrl='~/Images/UnAllocatedSeat.png',IsActive=0 
--WHERE UserType=2 AND SeatUrl='~/Images/OtherAreaSeats.png' AND IsActive=0

--UPDATE Eticket_MAP_BUS_SEAT SET SeatUrl='~/Images/OtherAreaSeats.png',IsActive=0 
--WHERE UserType=2 AND SeatUrl='~/Images/UnAllocatedSeat.png' AND IsActive=0
