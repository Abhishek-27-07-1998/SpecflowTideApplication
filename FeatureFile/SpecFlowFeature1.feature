Feature: TideApp
	Signup for creating account in tide application

@SignUpWithValidData
Scenario:SignUpWithValidData
	Given Load the URL
	When Click on Register
	And You Click on SignUp
	And Enter FirstName,Email,Password
	And Click on Create Account
	Then Account created and take Screenshot

@SIgnupWithInvalidData
Scenario:SignUpWithInvalidData
	Given Open the URL
	When Click on RegisterLink
	And You Click on SignUpFeature
	And Enter invalid FirstName,Email,Password
	And Click on Create Account button
	Then Account is not created and error message is displayed and take Screenshot

@LoginFeatureWithValidData
Scenario:LoginWithValidCredentials
	Given Open the Link
	When Click upon Register
	And you Click on SignUpFeature
	And Click on login
	And Enter the valid login credentials
	Then logged in successfully

@LoginFeature
Scenario:LoginWithInvalidCredentials
	Given User load the URL
	When Click on the Register
	And user click on Signup
	And Click upon login
	And Enter invalid login credentials
	Then User is unable to login 

@SignUpFeature
Scenario:SignupReadDataFromExcel
	Given User load the Link
	When Clicks on Register
	And user clicks upon Signup
	And Enter Firstname,Email,Password values from excel
	And Click on create account 
	Then account is created successfully

@ShopProducts
Scenario:ShopProducts
	Given I load the URL
	When I hover on the shop products
	And I Click on Liquids
	And Click on Buy now from available retailers
	Then Check for product availability

@CuponsAndRewards
Scenario: Cupons And Rewards
	Given You load the URL
	When I Click on Cupons and Rewards
	And Click on save now
	And Login to your account
	Then save cupon successfully
@LocationDropdown
Scenario: LocationDropDown
	Given Load the URL given
	When You select location dropdown
	And Select Canada-French
	Then verify if the page is displayed in French

@Livechat
Scenario: LiveChatFeature
	Given Load the Website
	When  You click on Livechat
	Then Chat option is available in UTC timings

@WhatsNeeFeaure
Scenario: Whats new Feature
	Given Load the ApplicationURL
	When You Click on Whats new
	And Click on Learn more
	Then Print all the links displayed

	
	