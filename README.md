# Azure SDK for Java

[![Packages](https://img.shields.io/badge/packages-latest-blue.svg)](https://azure.github.io/azure-sdk/releases/latest/java.html) [![Dependencies](https://img.shields.io/badge/dependencies-report-blue.svg)](https://azuresdkartifacts.blob.core.windows.net/azure-sdk-for-java/staging/dependencies.html) [![DepGraph](https://img.shields.io/badge/dependencies-graph-blue.svg)](https://azuresdkartifacts.blob.core.windows.net/azure-sdk-for-java/staging/InterdependencyGraph.html) [![Build Documentation](https://img.shields.io/badge/documentation-published-blue.svg)](https://azuresdkartifacts.blob.core.windows.net/azure-sdk-for-java/index.html) [![SpotBugs](https://img.shields.io/badge/SpotBugs-Clean-success.svg)](https://azuresdkartifacts.blob.core.windows.net/azure-sdk-for-java/staging/spotbugsXml.html) [![CheckStyle](https://img.shields.io/badge/CheckStyle-Clean-success.svg)](https://azuresdkartifacts.blob.core.windows.net/azure-sdk-for-java/staging/checkstyle-aggregate.html)

This repository is for active development of the Azure SDK for Java. For consumers of the SDK we recommend visiting our [public developer docs](https://docs.microsoft.com/en-us/java/azure/) or our versioned [developer docs](https://azure.github.io/azure-sdk-for-java).

## Getting started

To get started with a specific service library, see the **README.md** file located in the library's project folder. You can find service libraries in the `/sdk` directory. For a list of all the services we support access our [list of all existing libraries](https://azure.github.io/azure-sdk/releases/latest/all/java.html). 

For tutorials, samples, quick starts and other documentation, visit [Azure for Java Developers](https://docs.microsoft.com/java/azure/).

### Prerequisites

Java 8 or later is required to use the new client libraries, otherwise Java 7 or later is required.

## Latest Release

Each service might have a number of libraries available from each of the following categories:

- [Client: New Releases](#Client-New-Releases)
- [Client: Previous Versions](#Client-Previous-Versions)
- [Management](#Management)


### Client: New Releases

New wave of packages that follow the [Azure SDK Design Guidelines for Java](https://azure.github.io/azure-sdk/java/guidelines/) and share a number of core features such as HTTP retries, logging, transport protocols, authentication protocols, etc., so that once you learn how to use these features in one client library, you will know how to use them in other client libraries. You can learn about these shared features [here](https://github.com/Azure/azure-sdk-for-java/blob/master/sdk/core/azure-core/README.md).

These libraries can be easily identified by folder, package, and namespaces names starting with `azure-`, e.g. `azure-keyvault`.

You can find the [most up to date list of all of the new packages on our page](https://azure.github.io/azure-sdk/releases/latest/index.html#java-packages). This list includes the most recent releases: both GA and preview.

> NOTE: If you need to ensure your code is ready for production use one of the stable, non-preview libraries.

### Client: Previous Versions

Last stable versions of packages that have been provided for usage with Azure and are production-ready. These libraries provide similar functionalities to the new libraries, as they allow you to use and consume existing resources and interact with them, for example: upload a blob. Previous library directories start with `microsoft-azure-`, e.g. `microsoft-azure-keyvault`. They might not implement the [guidelines](https://azure.github.io/azure-sdk/java_introduction.html) or have the same feature set as the GA releases. They do however offer wider coverage of services.

### Management

Libraries which enable you to provision specific resources. They are responsible for directly mirroring and consuming Azure service's REST endpoints. Management library directories contain `-mgmt-`, e.g. `azure-mgmt-keyvault`.

## Need help?

* For reference documentation visit the [Azure SDK for Java documentation](http://aka.ms/java-docs).
* For tutorials, samples, quick starts and other documentation, visit [Azure for Java Developers](https://docs.microsoft.com/java/azure/).
* For build reports on code quality, test coverage, etc, visit [Azure Java SDK](https://azuresdkartifacts.blob.core.windows.net/azure-sdk-for-java/index.html).
* File an issue via [Github Issues](https://github.com/Azure/azure-sdk-for-java/issues/new/choose).
* Check [previous questions](https://stackoverflow.com/questions/tagged/azure-java-sdk) or ask new ones on StackOverflow using `azure-java-sdk` tag.

## Navigating the repository

### Master branch
The master branch has the most recent code with new features and bug fixes. It does **not** represent latest released **GA** SDK. See [above](#Client-New-Releases) for latest **GA** release.<br/>

### Release branches (Release tagging)

For each package we release there will be a unique git tag created that contains the name and the version of the package to mark the commit of the code that produced the package. This tag will be used for servicing via hotfix branches as well as debugging the code for a particular preview or stable release version.
Format of the release tags are `<package-name>_<package-version>`. For more information please see [our branching strategy](https://github.com/Azure/azure-sdk/blob/master/docs/policies/repobranching.md#release-tagging).

## Contributing

For details on contributing to this repository, see the [contributing guide](CONTRIBUTING.md).

This project welcomes contributions and suggestions. Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit
https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions provided by the bot. You will only need to do this once across all repositories using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

### Additional Helpful Links for Contributors

Many people all over the world have helped make this project better.  You'll want to check out:

* [What are some good first issues for new contributors to the repo?](https://github.com/azure/azure-sdk-for-java/issues?q=is%3Aopen+is%3Aissue+label%3A%22up+for+grabs%22)
* [How to build and test your change](CONTRIBUTING.md#developer-guide)
* [How you can make a change happen!](CONTRIBUTING.md#pull-requests)
* Frequently Asked Questions (FAQ) and Conceptual Topics in the detailed [Azure SDK for Java wiki](https://github.com/azure/azure-sdk-for-java/wiki).

### Community

* Chat with other community members [![Join the chat at https://gitter.im/azure/azure-sdk-for-java](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/azure/azure-sdk-for-java?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

### Reporting security issues and security bugs

Security issues and bugs should be reported privately, via email, to the Microsoft Security Response Center (MSRC) <secure@microsoft.com>. You should receive a response within 24 hours. If for some reason you do not, please follow up via email to ensure we received your original message. Further information, including the MSRC PGP key, can be found in the [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue).

### License

Azure SDK for Java is licensed under the [MIT](LICENSE.txt) license.

![Impressions](https://azure-sdk-impressions.azurewebsites.net/api/impressions/azure-sdk-for-java%2FREADME.png)
