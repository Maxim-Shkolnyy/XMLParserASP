namespace xmlParserASP.Services.UpdateServices;

public interface ISupplierUpdater
{
    Task <List<(string, string)>> Update(string tableColumnToUpdate);
}