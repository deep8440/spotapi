
# Io.Gate.GateApi.Model.FlashSwapOrderRequest

Parameters of flash swap order creation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PreviewId** | **string** | Preview result ID | [optional] 
**SellCurrency** | **string** | Currency to sell which can be retrieved from supported currency list API &#x60;GET /flash_swap/currencies&#x60; | 
**SellAmount** | **string** | Amount to sell. It is required to choose one parameter between &#x60;sell_amount&#x60; and &#x60;buy_amount&#x60; | [optional] 
**BuyCurrency** | **string** | Currency to buy which can be retrieved from supported currency list API &#x60;GET /flash_swap/currencies&#x60; | 
**BuyAmount** | **string** | Amount to buy. It is required to choose one parameter between &#x60;sell_amount&#x60; and &#x60;buy_amount&#x60; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
