# Avatool Version 1.0.0 Development Notes

***AVATOOL IS CURRENTLY BETA SOFTWARE. USE AT YOUR OWN RISK***

*Last updated 9/9/19*
> Application/data versions:
* Json.NET v12.0.2

## Questions/Comments/Feedback
Please let me know what you think: feedback@aprettycoolprogram.com

## The myAvatool project
Avatool is currently part of the older [myAvatool project](https://github.com/APrettyCoolProgram/myAvatool).

## myAvatool production codebase
* Avatool is currently being developed by A Pretty Cool Program, and the source code can be found at the [Avatool GitHub page] (https://github.com/APrettyCoolProgram/Avatool)
* Stable releases of myAvatool User Management can be found [here](https://github.com/APrettyCoolProgram/Avatool/releases)
* 
## myAvatool User Management development codebase
* While under development, myAvatool is heavily commented. There are two types of comments in the codebase:
  * Comments that start with "//" detail code-specific information, and should not be removed.
  * Comments within "/* */" are used during development to provide additional detail, and can be removed.
  * Comments that start with "///" are XML-comments used by Visual Studio, so you probably shouldn't remove them.
 
## Netsmart Avatar Web Services
### How to get the list of Netsmart Avatar Web Services
To get a list of the current Netsmart Avatar Web Services:
1. Login to myAvatar
2. Click **Help**
3. Click **Radplus YYYY** (i.e. "RADplus 2017")
4. Type *"Web Services"* in the search bar
5. Click **List of Avatar Web Services**

### List of Netsmart Avatar Web Services
*This is the list of Avatar Web Services as of 9/9/2019*
* Avatar RADplus Web Services
  * DocM.DocManagementWebService
  * WEBSVC.ClientAlerts
  * WEBSVC.DCIImport
  * WEBSVC.DictionaryUpdate
* Avatar PM Web Services
  * WEBSVC.ProgramMaintenance
  * WEBSVC.AppointmentSchedulingV2
  * WEBSVC.AppointmentScheduling
  * WEBSVC.ApptPractitionerTotal
  * WEBSVC.AttendingPractitioner
  * WEBSVC.ClientAdmission
  * WEBSVC.ClientChargeInput
  * WEBSVC.ClientDemographicsV2 web service
  * WEBSVC.ClientDemographics
  * WEBSVC.ClientDiagnosis
  * WEBSVC.ClientDischarge
  * WEBSVC.ClientEligibility Web Service
  * WEBSVC.ClientLookup
  * WEBSVC.ClientPreAdmitDischarge
  * WEBSVC.ConsentForAccess.Update42CFR
  * WEBSVC.ConsentForAccess.UpdateHIE
  * WEBSVC.ConsentForAccess.UpdateReferrals
  * WEBSVC.CrossEpisodeFinancialEligibility
  * WEBSVC.DeleteLastMovement
  * WEBSVC.DiagnosisV2
  * WEBSVC.Diagnosis
  * WEBSVC.DictionaryUpdate
  * WEBSVC.EditServiceInformation
  * WEBSVC.FinancialInvestigationV2
  * WEBSVC.FinancialInvestigation
  * WEBSVC.Financial Eligibility
  * WEBSVC.GuarantorsPayors
  * WEBSVC.HIPAA997Process
  * WEBSVC.IndividualCashPosting
  * WEBSVC.ManagedCareAuths
  * WEBSVC.NotificationService
  * WEBSVC.PaymentAdvice835
  * WEBSVC.PostingAdjustmentCodes
  * WEBSVC.PractitionerRegister
  * WEBSVC.ProgramTransfer
  * WEBSVC.ReferralSourceMaintenance
  * WEBSVC.SFMIAllPopulationHealth
  * WEBSVC.SFMIClientProfile
  * WEBSVC.SFMIDDProxyMeasures
  * WEBSVC.SFMIEnrollmentElig
  * WEBSVC.SFMIFuncAssess Web Service
  * WEBSVC.SFMITaxableIncome
  * WEBSVC.SiteRegistration
  * WEBSVC.StaffMemberHoursExceptions
  * WEBSVC.TeamDefinition
  * WEBSVC.TEDSAdmission Web Service
  * WEBSVC.TEDSDischarge
  * WEBSVC.ToDoItem
  * WEBSVC.UserManagement
  * WSAPI.PM.Appointment.AppointmentServiceV2
  * WSAPI.PM.Appointment.AppointmentService
  * WSAPI.PM.BedCodes.BedCodesService
  * WSAPI.PM.Client.ClientServiceV2 Web Service
  * WSAPI.PM.Client.ClientService
  * WSAPI.PM.ClientServices.ClientServicesService
  * WSAPI.PM.DictionaryCodes.DictionaryCodesService
  * WSAPI.PM.EligTableDemographics.EligTableDemographicsService
  * WSAPI.PM.Episodes.EpisodesServices
  * WSAPI.PM.Financial.FinancialInvestigationServiceV2
  * WSAPI.PM.GroupCodes.GroupCodesService
  * WSAPI.PM.GuarantorCodes.GuarantorCodesServiceV2
  * WSAPI.PM.GuarantorCodes.GuarantorCodesService
  * WSAPI.PM.ProgramCodes.ProgramCodesService
  * WSAPI.PM.ServiceCodes.ServiceCodesService
  * WSAPI.PM.SiteCodes.SiteCodesService
  * WSAPI.PM.Staff.StaffService
  * WSAPI.PM.UnitCodes.UnitCodesService
  * WSAPI.RADplus.Authenticate.AuthenticateService
  * WSAPI.RADplus.ToDo.ToDoService
  * WSAPI.RADplusDictionaryCodes.DictionaryCodesService
* Avatar Cal-PM Web Services
  * WEBSVC.AdmissionV2
  * WEBSVC.CalOMSAdmission
  * WEBSVC.CalOMSAnnualUpdate
  * WEBSVC.CalOMSDischarge
  * WEBSVC.ClientDiagnosisV2
  * WEBSVC.ClientDischargeV2
  * WEBSVC.ClientPregnancyV2
  * WEBSVC.ClientPregnancy
  * WEBSVC.ClientPregnancyV2
  * WEBSVC.ClinicianServicesV2
  * WEBSVC.CSIAdmission
  * WEBSVC.CSIClientAdmissionV2
  * WEBSVC.DictionaryUpdate
  * WEBSVC.FinancialEligibilityV2
  * WEBSVC.Leaves
  * WEBSVC.PostingAdjustmentCodes - CalPM Web Service
  * WEBSVC.ClinicianServices
  * WEBSVC.Practitioner Termination
  * WEBSVC.ProgramMaintenance
  * WEBSVC.ReferralSourceMaintenance
  * WEBSVC.ReturnFromLeaves
* Avatar CWS Web Services
  * Avatar CWS WSAPI.RADplus.Authenticate.AuthenticateService web service
  * Avatar CWS WSAPI.RADplus.DictionaryCodes.DictionaryCodesService web service
  * Avatar CWS WSAPI.RADplus.ToDo.ToDoService web service
  * WEBSVC.ClientAllergies Web Service
  * WEBSVC.ClientVitals
  * WEBSVC.OrderEntryOrders
  * WEBSVC.PHPData Web Service
  * WEBSVC.ProblemList Web Service
  * WEBSVC.ProgressNotes.Client.Request
  * WEBSVC.ProgressNotes.Group.Request
  * WSAPI.CWS.Allergy.AllergyService Web Service
  * WSAPI.CWS.Vitals.VitalsService Web Service
  * WSAPI.OrderEntry.LabOrders.LabOrdersService Web Service
  * WSAPI.OrderEntry.MedOrders.MedOrdersService web service
* Avatar MSO Web Services
  * WEBSVC.ClaimEntry
  * WEBSVC.ClaimPreAdjudication
  * WEBSVC.MemberEnrollment
  * WEBSVC.MemberTermination
  * WEBSVC.MSOToParentMapping
  * WEBSVC.ServiceAuthorization
  * WEBSVC.ServiceEntry
  * WEBSVC.SFMIPIAdmissionAppt
  * WEBSVC.SFMIPIAssessmentApt
  * WEBSVC.SFMIPIDtxaftercareApt
  * WEBSVC.SFMIPISentinelEvent
  * WEBSVC.SFNCcapcasemanage
  * WEBSVC.SFNCclientlookup
  * WEBSVC.SFNCduplicatecheck
  * WEBSVC.SFNCiptreatrep
  * WEBSVC.SFNCLmeinfo
  * WEBSVC.SFNCmcaidelig
  * WEBSVC.SFNCopreviewform
  * WEBSVC.SFNCtrmtauthreq
  * WEBSVC.UpdateMemberDemographics
* Avatar CFMS Web Services
  * WEBSVC.TransactionPosting

### Adding a Netsmart Avatar Web Service to your project
You can add a Netsmart Avatar Web Service to you project in one of two ways:

#### The Probably More Right Way
This is the original way that Netsmart Web Services were added to myAvatool. I couln't figure out a good way to make Web Services dynamic, so I used the second (older) method below. I'm leaving these instructions here in the event that I do figure out a way to make Web Services dynamic using this method.
1. Right-click on your project
2. Click **Add**
3. Click **Service Reference**
4. In the *Address* field, put the name of the Web Service you want to add. It should look something like this:
    ```
    http://<SERVER>:<PORT>/csp/AVPM/WEBSVC.<WEBSERVICE-NAME>.CLS?WSDL
    ```
    For example, to add the User Management Web Service, you would put:
    ```
    http://SANDBOX:8972/csp/AVPM/WEBSVC.UserManagement.CLS?WSDL
    ```
5. Click **Go**. The Web Service should be found.
6. In the *Namespace* field, give the Web Service a name. This is the name that your project will use to reference
       the Web Service, so make it something meaningful. For example:
        `NTSTWebSvcUserManagementUAT`
7. Click **Ok**.
If you encounter an error at step #4, copy/paste the Web Service URL into a web browser. The WSDL code should be displayed.
Repeat steps 1-5 for each of your Avatar environments.

#### The Probably The Less Right Way
Since I couldn't get Web Services to be dynmic using the (newer) method above, I used the older (.NET 2.x) method, which is:
1. Right-click on your project
2. Click **Add**
3. Click **Service Reference**
4. Click the **Advanced** button
4. Click the **Add Web Service** button
4. In the *URL* field, put the name of the Web Service you want to add. It should look something like this:
    ```
    http://<SERVER>:<PORT>/csp/AVPM/WEBSVC.<WEBSERVICE-NAME>.CLS?WSDL
    ```
    For example, to add the User Management Web Service, you would put:
    ```
    http://SANDBOX:8972/csp/AVPM/WEBSVC.ClientAdmission.CLS?WSDL
    ```
5. Click the arrow icon to the right of the URL. The Web Service should be found.
6. In the *Web reference name* field, give the Web Service a name. This is the name that your project will use to reference
       the Web Service, so make it something meaningful. For example:
        `NTSTWebSvcUATUserManagement`
7. Click **Add Reference**.
If you encounter an error at step #4, copy/paste the Web Service URL into a web browser. The WSDL code should be displayed.
Repeat steps 1-5 for each of your Avatar environments.

### Netsmart Web Services that are currently used with myAvatool User Management
myAvatool uses the following Netsmart Web Services/calls:
* User Management (WEBSVC.UserManagement.CLS)
  * **ActivateUser**
  * CreateUser
  * **DeactivateUser**
  * **DoesUserExist**
  * **GeneratePassword**
  * GetDictionaryItems
  * GetUserRoleList
  * **IsUserActive**
  * UpdateUser