Config file
Path: .\TfLCodingChallenge\TfLCodingChallenge\TfLCodingChallenge\App.config
once it is open, fill the with the corresponding values
<add key="applicationId" value="yourApplicationId"/>
<add key="applicationKey" value="yourApplicationKey"/>

Build the application
open a command prompt
go to .\TfLCodingChallenge\TfLCodingChallenge\TfLCodingChallenge
type the following command in the prompt: dotnet build

launch the application
open a command prompt
go to .\TfLCodingChallenge\TfLCodingChallenge\TfLCodingChallenge
type the following command in the prompt: dotnet run A2
dotnet run A233

Test the application 
open a command prompt
go to .\TfLCodingChallenge\TfLCodingChallenge\TflCodingChallengeTest
type the following command in the prompt: dotnet test

Assumptions and remarks
there is no specif error message in case of missing or wrong data in the configuraion file

In a larger scale application, it would be better to use the dependency injection pattern in order to ease the maintenance