using MediatR;
using Microsoft.EntityFrameworkCore;
using RunTracker.Application.Common.Interfaces;

namespace RunTracker.Application.Badges.Commands;

public record ArchiveBadgeCommand(int BadgeId) : IRequest<bool>;

public class ArchiveBadgeCommandHandler : IRequestHandler<ArchiveBadgeCommand, bool>
{
    private readonly IApplicationDbContext _db;
    public ArchiveBadgeCommandHandler(IApplicationDbContext db) => _db = db;

    public async Task<bool> Handle(ArchiveBadgeCommand request, CancellationToken ct)
    {
        var badge = await _db.BadgeDefinitions.FindAsync([request.BadgeId], ct);
        if (badge is null) return false;
        badge.IsArchived = true;
        await _db.SaveChangesAsync(ct);
        return true;
    }
}

public record UnarchiveBadgeCommand(int BadgeId) : IRequest<bool>;

public class UnarchiveBadgeCommandHandler : IRequestHandler<UnarchiveBadgeCommand, bool>
{
    private readonly IApplicationDbContext _db;
    public UnarchiveBadgeCommandHandler(IApplicationDbContext db) => _db = db;

    public async Task<bool> Handle(UnarchiveBadgeCommand request, CancellationToken ct)
    {
        var badge = await _db.BadgeDefinitions.FindAsync([request.BadgeId], ct);
        if (badge is null) return false;
        badge.IsArchived = false;
        await _db.SaveChangesAsync(ct);
        return true;
    }
}

public record UpdateBadgeSortOrderCommand(int BadgeId, int SortOrder) : IRequest<bool>;

public class UpdateBadgeSortOrderCommandHandler : IRequestHandler<UpdateBadgeSortOrderCommand, bool>
{
    private readonly IApplicationDbContext _db;
    public UpdateBadgeSortOrderCommandHandler(IApplicationDbContext db) => _db = db;

    public async Task<bool> Handle(UpdateBadgeSortOrderCommand request, CancellationToken ct)
    {
        var badge = await _db.BadgeDefinitions.FindAsync([request.BadgeId], ct);
        if (badge is null) return false;
        badge.SortOrder = request.SortOrder;
        await _db.SaveChangesAsync(ct);
        return true;
    }
}
