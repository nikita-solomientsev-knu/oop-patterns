namespace ProxyProject;

using System;


public class ServerProxy: IServer {
    private uint _cacheTimeToLive;
    private DateTime _cacheLastTimeUpdate;
    private string? _resourceCache = null;
    private string _resourceFilename;

    public ServerProxy(string resourceFilename, uint cacheTtl) {
        _cacheTimeToLive = cacheTtl;
        _resourceFilename = resourceFilename;
        _cacheLastTimeUpdate = DateTime.Now;
    }

    public string GetResource() {
        if (_resourceCache == null || (DateTime.Now - _cacheLastTimeUpdate).TotalSeconds > _cacheTimeToLive) {
            _resourceCache = new Server(_resourceFilename).GetResource();
        }
        return _resourceCache;
    }
}
