using Microsoft.EntityFrameworkCore;
using ERP_BACKEND.constracts;
using ERP_BACKEND.data;
using ERP_BACKEND.dtos;
using ERP_BACKEND.interfaces;
namespace ERP_BACKEND.services;


public class LoggerService : ILoggerinterface
{
    private readonly AppDbContext _context;
    public LoggerService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<AppActivity> SavelogAsync(LogEntry logEntry, string userAgent)
    {
        var activity = new AppActivity
        {
            EventName = logEntry.EventName,
            PagePath = logEntry.Path,
            SearchQuery = logEntry.Search,
            PageTitle = logEntry.Title,
            UserAgent = userAgent
        };

        _context.AppActivity.Add(activity);
        await _context.SaveChangesAsync();
        return activity;
    }
}