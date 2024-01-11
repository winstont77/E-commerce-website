電商網頁  
後端:.net core 6、SQL Server  
前端:Vue3  
ORM:Entity Framework  
系統設計模式:MVC + Service + Repository  

ResfulAPI  
客戶端服務器分離: Client不關心持久化的資料儲存。客戶端不會儲存使用者資訊、商品資訊，全部向server端拿取。  
無狀態: 使用Jwt作為登入狀態的應用。Server與Client不儲存連接歷史，每個請求都是獨立的。  
統一介面: Get、Post。具有HTTP Methods、route與明確定義的請求與響應資料結構的組合。  
可快取性: 使用Radis作為購物車內容的第一站資料庫，沒有資料才會向SQL Server拿取資料。  

專案內容:  
會員功能(登入、註冊)
購物功能(購物車、串接TapPay支付)
