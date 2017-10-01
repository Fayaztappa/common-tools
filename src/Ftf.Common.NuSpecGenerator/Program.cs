using System;
using System.Threading.Tasks;


namespace Ftf.Common.NuSpecGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new[] {"pack", "Ftf.Common.NuSpecGenerator.csproj", @"C:\Development\common-framework\src\Ftf.Common.NuSpecGenerator\bin\Debug"};
            //BuildPackage("Ftf.Common.NuSpecGenerator.csproj", "bin\\debug");

            //if (string.Equals(args[0], "spec", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    new SpecFileGenerator(args[1], args[2]).Generate();
            //}
            //else if (string.Equals(args[0], "pack", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    new PackageGenerator(args[1], args[2]).Generate();
            //}
        }



        //public static void BuildPackage(string projectFile, string outputPath)
        //{
        //    var rootDir = @"C:\Development\common-framework\src\Ftf.Common.NuSpecGenerator\";
        //    var packArgs = new PackArgs()
        //    {
        //        Logger = new ConsoleLogger(),
        //        Arguments = new []{ projectFile },
        //        OutputDirectory = rootDir+outputPath,
        //        Path= projectFile,
        //        CurrentDirectory = rootDir,
        //        MsBuildDirectory = new Lazy<string>(()=> { return @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\"; }),
        //        Build = false,
        //        BasePath= rootDir+ "Ftf.Common.NuSpecGenerator.NuSpec",
        //        Symbols = false,
        //        Exclude = new List<string>()
        //    };

        //    //packArgs.Properties.Add("version","1.0.0.0");

        //    //IPackageBuilder packageBuilder = new PackageBuilder(packArgs, NullPropertyProvider.Instance);

        //    var builder = new NuGet.Packaging.PackageBuilder(packArgs.BasePath, GetProperty, false);

        //    PackCommandRunner packCommand = new PackCommandRunner(packArgs,GetFactory, builder){GenerateNugetPackage = false};

        //    packCommand.BuildPackage();

        //    Console.ReadKey();
        //}
    }


    //internal class ConsoleLogger : ILogger
    //{
    //    public void LogDebug(string data)
    //    {
    //        Log(LogLevel.Debug, data);
    //    }

    //    public void LogVerbose(string data)
    //    {
    //        Log(LogLevel.Verbose, data);
    //    }

    //    public void LogInformation(string data)
    //    {
    //        Log(LogLevel.Information, data);
    //    }

    //    public void LogMinimal(string data)
    //    {
    //        Log(LogLevel.Minimal, data);
    //    }

    //    public void LogWarning(string data)
    //    {
    //        Log(LogLevel.Warning, data);
    //    }

    //    public void LogError(string data)
    //    {
    //        Log(LogLevel.Error, data);
    //    }

    //    public void LogInformationSummary(string data)
    //    {
    //        Log(LogLevel.Information, data);
    //    }

    //    public void Log(LogLevel level, string data)
    //    {
    //        Console.WriteLine("{0}_{1}",level,data);
    //    }

    //    public Task LogAsync(LogLevel level, string data)
    //    {
    //        return Task.Run(() =>
    //        {
    //            Log(level, data);
    //        });
    //    }

    //    public void Log(ILogMessage message)
    //    {
    //        Console.WriteLine("{0}", message);
    //    }

    //    public Task LogAsync(ILogMessage message)
    //    {
    //        return Task.Run(() =>
    //        {
    //            Log(message);
    //        });
    //    }
    //}

    //public class Manifest
    //{
    //    private const string SchemaVersionAttributeName = "schemaVersion";

    //    public Manifest(ManifestMetadata metadata)
    //                : this(metadata, null)
    //    {
    //    }

    //    public Manifest(ManifestMetadata metadata, ICollection<ManifestFile> files)
    //    {
    //        if (metadata == null)
    //        {
    //            throw new ArgumentNullException(nameof(metadata));
    //        }

    //        Metadata = metadata;

    //        if (files != null)
    //        {
    //            Files = files;
    //            HasFilesNode = true;
    //        }
    //        else
    //        {
    //            HasFilesNode = false;
    //        }
    //    }

    //    public ManifestMetadata Metadata { get; }

    //    public ICollection<ManifestFile> Files { get; } = new List<ManifestFile>();

    //    public bool HasFilesNode { get; }
        
    //    public void Save(Stream stream, bool validate, int minimumManifestVersion)
    //    {
    //        if (validate)
    //        {
    //            // Validate before saving
    //            Validate(this);
    //        }

    //        int version = Math.Max(minimumManifestVersion, ManifestVersionUtility.GetManifestVersion(Metadata));
    //        var schemaNamespace = (XNamespace)ManifestSchemaUtility.GetSchemaNamespace(version);

    //        new XDocument(
    //            new XElement(schemaNamespace + "package",
    //                Metadata.ToXElement(schemaNamespace),
    //                Files.Any() ?
    //                    new XElement(schemaNamespace + "files",
    //                        Files.Select(file => new XElement(schemaNamespace + "file",
    //                            new XAttribute("src", file.Source),
    //                            file.Target != null ? new XAttribute("target", file.Target) : null,
    //                            file.Exclude != null ? new XAttribute("exclude", file.Exclude) : null))) : null)).Save(stream);
    //    }

    //    public static Manifest ReadFrom(Stream stream, bool validateSchema)
    //    {
    //        return ReadFrom(stream, null, validateSchema);
    //    }

    //    public static Manifest ReadFrom(Stream stream, Func<string, string> propertyProvider, bool validateSchema)
    //    {
    //        XDocument document;
    //        if (propertyProvider == null)
    //        {
    //            document = XmlUtility.LoadSafe(stream, ignoreWhiteSpace: true);
    //        }
    //        else
    //        {
    //            string content = Preprocessor.Process(stream, propName => propertyProvider(propName));
    //            document = XDocument.Parse(content);
    //        }

    //        string schemaNamespace = GetSchemaNamespace(document);
    //        foreach (var e in document.Descendants())
    //        {
    //            // Assign the schema namespace derived to all nodes in the document.
    //            e.Name = XName.Get(e.Name.LocalName, schemaNamespace);
    //        }

    //        // Validate if the schema is a known one
    //        CheckSchemaVersion(document);

    //        if (validateSchema)
    //        {
    //            // Validate the schema
    //            ValidateManifestSchema(document, schemaNamespace);
    //        }
    //    }

    //    private static string GetSchemaNamespace(XDocument document)
    //    {
    //        string schemaNamespace = ManifestSchemaUtility.SchemaVersionV1;
    //        var rootNameSpace = document.Root.Name.Namespace;
    //        if (rootNameSpace != null && !String.IsNullOrEmpty(rootNameSpace.NamespaceName))
    //        {
    //            schemaNamespace = rootNameSpace.NamespaceName;
    //        }
    //        return schemaNamespace;
    //    }

    //    //        public static Manifest Create(IPackageMetadata metadata)
    //    //        {
    //    //            return new Manifest(new ManifestMetadata(metadata));
    //    //        }

    //    //        private static void ValidateManifestSchema(XDocument document, string schemaNamespace)
    //    //        {
    //    //#if !IS_CORECLR // CORECLR_TODO: XmlSchema
    //    //            var schemaSet = ManifestSchemaUtility.GetManifestSchemaSet(schemaNamespace);

    //    //            document.Validate(schemaSet, (sender, e) =>
    //    //            {
    //    //                if (e.Severity == XmlSeverityType.Error)
    //    //                {
    //    //                    var message = e.Message;

    //    //                    // To make sure this error message is actionable, try to add the element name
    //    //                    // where the error is occurring.
    //    //                    var senderElement = sender as XElement;
    //    //                    if (senderElement != null)
    //    //                    {
    //    //                        message = string.Format(
    //    //                            CultureInfo.CurrentCulture,
    //    //                            Strings.InvalidNuspecElement,
    //    //                            message,
    //    //                            senderElement.Name.LocalName);
    //    //                    }

    //    //                    // Throw an exception if there is a validation error
    //    //                    throw new InvalidOperationException(message);
    //    //                }
    //    //            });
    //    //#endif
    //    //        }

    //    //        private static void CheckSchemaVersion(XDocument document)
    //    //        {
    //    //#if !IS_CORECLR // CORECLR_TODO: XmlSchema
    //    //            // Get the metadata node and look for the schemaVersion attribute
    //    //            XElement metadata = GetMetadataElement(document);

    //    //            if (metadata != null)
    //    //            {
    //    //                // Yank this attribute since we don't want to have to put it in our xsd
    //    //                XAttribute schemaVersionAttribute = metadata.Attribute(SchemaVersionAttributeName);

    //    //                if (schemaVersionAttribute != null)
    //    //                {
    //    //                    schemaVersionAttribute.Remove();
    //    //                }

    //    //                // Get the package id from the metadata node
    //    //                string packageId = GetPackageId(metadata);

    //    //                // If the schema of the document doesn't match any of our known schemas
    //    //                if (!ManifestSchemaUtility.IsKnownSchema(document.Root.Name.Namespace.NamespaceName))
    //    //                {
    //    //                    throw new InvalidOperationException(
    //    //                            String.Format(CultureInfo.CurrentCulture,
    //    //                                          NuGetResources.IncompatibleSchema,
    //    //                                          packageId,
    //    //                                          typeof(Manifest).Assembly.GetName().Version));
    //    //                }
    //    //            }
    //    //#endif
    //    //        }

    //    //        private static string GetPackageId(XElement metadataElement)
    //    //        {
    //    //            XName idName = XName.Get("id", metadataElement.Document.Root.Name.NamespaceName);
    //    //            XElement element = metadataElement.Element(idName);

    //    //            if (element != null)
    //    //            {
    //    //                return element.Value;
    //    //            }

    //    //            return null;
    //    //        }

    //    //        private static XElement GetMetadataElement(XDocument document)
    //    //        {
    //    //            // Get the metadata element this way so that we don't have to worry about the schema version
    //    //            XName metadataName = XName.Get("metadata", document.Root.Name.Namespace.NamespaceName);

    //    //            return document.Root.Element(metadataName);
    //    //        }

    //    //        public static void Validate(Manifest manifest)
    //    //        {
    //    //            var results = new List<string>();

    //    //            // Run all validations
    //    //            results.AddRange(manifest.Metadata.Validate());
    //    //            foreach (var manifestFile in manifest.Files)
    //    //            {
    //    //                results.AddRange(manifestFile.Validate());
    //    //            }

    //    //            if (manifest.Metadata.PackageAssemblyReferences != null)
    //    //            {
    //    //                foreach (var packageAssemblyReference in manifest.Metadata.PackageAssemblyReferences)
    //    //                {
    //    //                    results.AddRange(packageAssemblyReference.Validate());
    //    //                }
    //    //            }

    //    //            if (results.Any())
    //    //            {
    //    //                string message = String.Join(Environment.NewLine, results);
    //    //                throw new Exception(message);
    //    //            }

    //    //            // Validate additional dependency rules dependencies
    //    //            ValidateDependencyGroups(manifest.Metadata);
    //    //        }

    //    //        private static void ValidateDependencyGroups(IPackageMetadata metadata)
    //    //        {
    //    //            foreach (var dependencyGroup in metadata.DependencyGroups)
    //    //            {
    //    //                var dependencyHash = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
    //    //                foreach (var dependency in dependencyGroup.Packages)
    //    //                {
    //    //                    // Throw an error if this dependency has been defined more than once
    //    //                    if (!dependencyHash.Add(dependency.Id))
    //    //                    {
    //    //                        throw new InvalidOperationException(String.Format(CultureInfo.CurrentCulture, NuGetResources.DuplicateDependenciesDefined, metadata.Id, dependency.Id));
    //    //                    }

    //    //                    // Validate the dependency version
    //    //                    ValidateDependencyVersion(dependency);
    //    //                }
    //    //            }
    //    //        }

    //    //        private static void ValidateDependencyVersion(PackageDependency dependency)
    //    //        {
    //    //            if (dependency.VersionRange != null)
    //    //            {
    //    //                if (dependency.VersionRange.MinVersion != null &&
    //    //                    dependency.VersionRange.MaxVersion != null)
    //    //                {

    //    //                    if ((!dependency.VersionRange.IsMaxInclusive ||
    //    //                         !dependency.VersionRange.IsMinInclusive) &&
    //    //                        dependency.VersionRange.MaxVersion == dependency.VersionRange.MinVersion)
    //    //                    {
    //    //                        throw new InvalidOperationException(String.Format(CultureInfo.CurrentCulture, NuGetResources.DependencyHasInvalidVersion, dependency.Id));
    //    //                    }

    //    //                    if (dependency.VersionRange.MaxVersion < dependency.VersionRange.MinVersion)
    //    //                    {
    //    //                        throw new InvalidOperationException(String.Format(CultureInfo.CurrentCulture, NuGetResources.DependencyHasInvalidVersion, dependency.Id));
    //    //                    }
    //    //                }
    //    //            }
    //    //        }
    //}
}
