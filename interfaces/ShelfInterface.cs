namespace ERP_BACKEND.interfaces;
using ERP_BACKEND.dtos;
public interface IShelfService
{
    Task<IEnumerable<readShelfDto>> GetAllShelfsAsync();
    Task<readShelfDto?> GetShelfByIdAsync(int id);
    Task<readShelfDto> CreateShelfAsync(createShelfDto ShelfDto);
    Task<bool> UpdateShelfAsync(int id, createShelfDto ShelfDto);
    Task<bool> DeleteShelfAsync(int id);
}