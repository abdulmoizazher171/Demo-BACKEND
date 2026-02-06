using  ERP_BACKEND.constracts;
using ERP_BACKEND.dtos;
namespace ERP_BACKEND.interfaces;
public interface ILoggerinterface
{
    Task <AppActivity> SavelogAsync (LogEntry logEntry, string userAgent);
}