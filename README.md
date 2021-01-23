<img src="/FilesAreDigitallySignedTool/FilesAreDigitallySignedTool.ico"></img>

# Files Are Digitally Signed Tool

Download installer from [www.michaelekins.co.uk](https://www.michaelekins.co.uk/projects.html#FilesAreDigitallySignedTool)

Files are digitally signed tool allows you to verify that a digital signature is present for any given file and view its details. This can be achieved either via a .csv output file generated via command line or by a UI.

It is important to set up the config file correctly before using the program:

```
<fileNames>
    <add key="0" value="C:\test1.exe" />
    <add key="1" value="C:\test2.dll" />
</fileNames>
```

The .csv export can be generated by calling the application with any parameters, eg:
``` 
“FilesAreDigitallySignedTool.exe -export”
```

The export can then be found in:

```
 <MyDocs>\Tools\FilesAreDigitallySigned\results.csv
```

Note that if a results file already exists, then the output filename will be results2.csv, results3.csv etc.

DuplicateLineRemover created by Michael Ekins 2016
