
# Io.Gate.GateApi.Model.SubAccountTransfer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | Transfer currency name | 
**SubAccount** | **string** | Sub account user ID | 
**Direction** | **string** | Transfer direction. to - transfer into sub account; from - transfer out from sub account | 
**Amount** | **string** | Transfer amount | 
**Uid** | **string** | Main account user ID | [optional] [readonly] 
**Timest** | **string** | Transfer timestamp | [optional] [readonly] 
**Source** | **string** | Where the operation is initiated from | [optional] [readonly] 
**SubAccountType** | **string** | Target sub user&#39;s account. &#x60;spot&#x60; - spot account, &#x60;futures&#x60; - perpetual contract account, &#x60;cross_margin&#x60; - cross margin account | [optional] [default to SubAccountTypeEnum.Spot]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
