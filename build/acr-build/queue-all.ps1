Param(
    [parameter(Mandatory=$false)][string]$acrName,
    [parameter(Mandatory=$false)][string]$gitUser,
    [parameter(Mandatory=$false)][string]$repoName="ShreyShopOnContainers",
    [parameter(Mandatory=$false)][string]$gitBranch="dev",
    [parameter(Mandatory=$true)][string]$patToken
)

$gitContext = "https://github.com/$gitUser/$repoName"

$services = @( 
    @{ Name="shreyshopbasket"; Image="shreyshop/basket.api"; File="src/Services/Basket/Basket.API/Dockerfile" },
    @{ Name="shreyshopcatalog"; Image="shreyshop/catalog.api"; File="src/Services/Catalog/Catalog.API/Dockerfile" },
    @{ Name="shreyshopidentity"; Image="shreyshop/identity.api"; File="src/Services/Identity/Identity.API/Dockerfile" },
    @{ Name="shreyshopordering"; Image="shreyshop/ordering.api"; File="src/Services/Ordering/Ordering.API/Dockerfile" },
	@{ Name="shreyshoporderingbg"; Image="shreyshop/orderprocessor"; File="src/Services/Ordering/OrderProcessor/Dockerfile" },
    @{ Name="shreyshopwebspa"; Image="shreyshop/webspa"; File="src/Web/WebSPA/Dockerfile" },
    @{ Name="shreyshopwebmvc"; Image="shreyshop/webmvc"; File="src/Web/WebMVC/Dockerfile" },
    @{ Name="shreyshopwebstatus"; Image="shreyshop/webstatus"; File="src/Web/WebStatus/Dockerfile" },
    @{ Name="shreyshoppayment"; Image="shreyshop/paymentprocessor"; File="src/Services/Payment/PaymentProcessor/Dockerfile" },
    @{ Name="shreyshopocelotapigw"; Image="shreyshop/ocelotapigw"; File="src/ApiGateways/ApiGw-Base/Dockerfile" },
    @{ Name="shreyshopmobilshreyshoppingagg"; Image="shreyshop/mobilshreyshoppingagg"; File="src/ApiGateways/Mobile.Bff.Shopping/aggregator/Dockerfile" },
    @{ Name="shreyshopwebshoppingagg"; Image="shreyshop/webshoppingagg"; File="src/ApiGateways/Web.Bff.Shopping/aggregator/Dockerfile" },
    @{ Name="shreyshoporderingsignalrhub"; Image="shreyshop/ordering.signalrhub"; File="src/Services/Ordering/Ordering.SignalrHub/Dockerfile" }
)

$services |% {
    $bname = $_.Name
    $bimg = $_.Image
    $bfile = $_.File
    Write-Host "Setting ACR build $bname ($bimg)"    
    az acr build-task create --registry $acrName --name $bname --image ${bimg}:$gitBranch --context $gitContext --branch $gitBranch --git-access-token $patToken --file $bfile
}
