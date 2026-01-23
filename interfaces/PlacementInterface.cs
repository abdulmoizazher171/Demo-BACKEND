using ERP_BACKEND.constracts;
using ERP_BACKEND.dtos;
using ERP_BACKEND.mappers;
namespace ERP_BACKEND.interfaces;

public interface IPlacementService
{
    Task<IEnumerable<PlacementMapper>> GetAllPlacementsAsync();
    Task<PlacementReadDto?> GetPlacementByIdAsync(int id);
    Task<PlacementReadDto> CreatePlacementAsync(PlacementCreateDto createDto);
    Task<bool> UpdatePlacementAsync(int id, PlacementModifyDto updateDto);
    Task<bool> DeletePlacementAsync(int id);
}