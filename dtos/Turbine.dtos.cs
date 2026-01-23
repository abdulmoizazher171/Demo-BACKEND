namespace ERP_BACKEND.dtos;

public record readTurbineDto
(
    int TurbineId,
    string SystemNumber
);


public record createTurbineDto
(
   
    string SystemNumber
);