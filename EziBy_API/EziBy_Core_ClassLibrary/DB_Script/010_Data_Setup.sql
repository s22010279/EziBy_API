INSERT INTO [dbo].[Setups](
 [BranchId]
,[CurrencyMark]
,[CurrencyDecimals]
,[InitialDeliveryDays]
,[MaximumDeliveryDays]
,[Android_OnGoingMaintenance]
,[Android_ForceUpdate]
,[Android_BuildNumber]
,[MainAPIUri]
,[MainSlideShowImagesUri]
,[CategoryImagesUri]
,[CategoryHeaderUri]
,[SubCategoryImagesUri]
,[ItemsImageUri]
,[BrandImageUri]
,[SocialMediaUri]
,[OtherImageUri]
,[TermsAndConditionsUri]
,[PrivacyPolicyUri]
,[OurServicesUri]
,[ContactUsUri]
,[AboutUsUri]
,[ServerMappedImagePath]
,[NewOrderRefreshInterval]
,[AllowDiscountInPOS]
,[Active]
,[CrystalReportPath])
VALUES (
 1	
,'Rs.'	
,2	
,2	
,7	
,0	
,0	
,1	
,'https://MobileApi.eziby.lk/'	
,'https://images.eziby.lk/EziBy_Images/MainSlideShowImage/'	
,'https://images.eziby.lk/EziBy_Images/Category/'	
,'https://images.eziby.lk/EziBy_Images/CategoryHeader/'	
,'https://images.eziby.lk/EziBy_Images/SubCategory/'	
,'https://images.eziby.lk/EziBy_Images/Item/'	
,'https://images.eziby.lk/EziBy_Images/Brand/'	
,'https://images.eziby.lk/EziBy_Images/SocialMedia/'
,'https://images.eziby.lk/EziBy_Images/Other/'	
,'https://ousl.eziby.lk/Home/termsandconditions'	
,'https://ousl.eziby.lk/Home/privacypolicy'	
,'https://ousl.eziby.lk/Home/OurServices'	
,'https://ousl.eziby.lk/Home/contactus'	
,'https://ousl.eziby.lk/Home/AboutUs'	
,'C:/Inetpub/vhosts/eziby.lk/'	
,1	
,1	
,1	
,'C:\EziBy_Reports\')