CREATE PROCEDURE [dbo].[AddOrUpdatePerson]
    @PersonId int,
    @PersonName varchar(250),
    @Items dbo.ItemTvp READONLY
AS
BEGIN
    set nocount on;

    merge into dbo.Person as target
        using (select @PersonId as Id, @PersonName as Name) as source
        on source.Id = target.Id
        when matched then update set Name = source.Name
        when not matched then insert values(source.Id, source.Name, 18);

    merge into dbo.Item as target
        using @Items as source
        on source.Id = target.Id
        when matched then update set Name = source.Name
        when not matched then insert values(source.Id, source.Name);

    delete from dbo.Inventory where PersonId = @PersonId;

    merge into dbo.Inventory as target
        using @Items as source
        on source.Id = target.ItemId and target.PersonId = @PersonId
        when not matched then insert values(@PersonId, source.Id);
END;
