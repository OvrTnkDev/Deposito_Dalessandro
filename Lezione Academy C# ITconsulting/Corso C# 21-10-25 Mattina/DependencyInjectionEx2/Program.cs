using System;
using System.Collections.Generic;

#region INTERFACCIA
public interface IStorageService
{
    string GetStorage();
}
#endregion

#region CLASSI STORAGE
public class DiskStorageService : IStorageService
{
    public string GetStorage() => "Disk Storage";
}
public class CloudStorageService : IStorageService
{
    public string GetStorage() => "Cloud Storage";
}
#endregion

#region CLASSI UPLOADER
public class FileUploader
{
    public IStorageService? StorageService { get; set; }

    public FileUploader(IStorageService? _storageService = null)
    {
        StorageService = _storageService;
    }
    public void Storage()
    {
        if (StorageService == null)
        {
            Console.WriteLine(StorageService?.GetStorage());
            return;
        }
        else
        {
            Console.WriteLine(StorageService.GetStorage());
        }
    }
}
#endregion

#region CLIENT
public class Program
{
    public static void Main(string[] Args)
    {
        FileUploader fileUploader1 = new FileUploader(new DiskStorageService());
        fileUploader1.Storage();

        FileUploader fileUploader2 = new FileUploader(new CloudStorageService());
        fileUploader2.Storage();
    }
}
#endregion