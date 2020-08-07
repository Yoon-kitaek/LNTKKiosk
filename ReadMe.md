# LotteNaldsTouchKing Kiosk (이하 LNTKK)


 ## 1. LTNK에 관하여
* 커스터마이징 햄버거를 판매하는 식당에서 사용가능한 프로그램이다.
* 고객용 키오스크와 관리자용 관리 시스템으로 구성되어 있다. 
* 고객은 키오스크를 사용하여 전산으로 주문 정보를 주방에 전달할 수 있다.
* 관리자는 관리 시스템을 사용하여 전산으로 주문 관리, 자재 관리를 할 수 있다.



## 2. 기능목록
#### 관리자 기능
1. 기능1
2. 기능2
3. 기능3
#### 사용자 기능
1. 장바구니에 담기   
   <p align="center"><img src="https://user-images.githubusercontent.com/63761587/89606787-e323c180-d8ab-11ea-9e8c-c3856c0709cc.png" height="60%" width="30%"></img>　　　　　　
　　　<img src="https://user-images.githubusercontent.com/63761587/89606821-f767be80-d8ab-11ea-8893-1d0a2f7f17fb.png" height="60%" width="30%"></img> </p>
   
2. 커스터마이징       
   <p align="center"><img src="https://user-images.githubusercontent.com/63761587/89606836-02baea00-d8ac-11ea-9e08-4a9147580d32.png" height="60%" width="30%" align="center"></img></p>
 
   

## 3. 행위 목록
#### 관리자
- 주문 정보를 관리한다.
- 기존 메뉴, 레시피, 식자재를 수정 및 삭제한다.
- 새로운 메뉴, 레시피, 식자재를 추가한다.
- 분기별 매출 실적을 확인한다.

#### 사용자
- 메뉴를 장바구니에 담는다.
- 장바구니에 담긴 메뉴들을 확인한다
- 세트 구성 및 햄버거 재료를 커스터마이징한다.

## 4. 사용 기술
### 언어
 - C# 3.0+
### 프레임워크
 - .Net FrameWork 4.8+
 - WinForm
 - Entity FrameWork 6.2+
### 3rd Party Control
 - Devexpress WinForm
### 데이터베이스
 - MSSQL Server 2019



## 5. 데이터베이스 스키마
![3차프로젝트DB](https://user-images.githubusercontent.com/63761587/89612643-4701b680-d8bb-11ea-82d2-299c18f5b421.png)




## 6. Point Of Interest
#### 폼들 사이에 정보를 주고 받기
장바구니에 담긴 상품 정보, 고객들이 커스터마이징 단계에서 변경한 세트 구성 및 버거 재료에 관한 정보는 결제가 끝날 때 까지 보관을 했다가 DB에 업데이트를 해야된다. 그래서 그 정보를 어떻게 전달할지에 대해 여러가지 방안들을 찾아봤다. 크게 이벤트 이용하는 법, 인터페이스를 사용하는 법, 그리고 singleton 패턴를 사용하는 방법에 대해 알아보았고, 이 중에서 singleton 패턴을 사용해서 문제를 해결했다.   

#### DotTrace를 사용해서 병목지점 찾기
테스트를 하는 과정에서, 메뉴를 띄우는 화면에서 그림들이 다 로딩되기까지 시간이 많이 걸린다는 것을 발견했다. 그래서 로딩 시간을 어떻게 줄일 수 있을까에 대한 고민을 하게 되었고, JetBrains라는 회사에서 만든 DotTrace라는 프로그램을 사용해서 정확히 어떤 부분에서 시간이 오래 걸리는지를 확인 할 수 있었다. 찾은 병목지점중에서는 현재 배운 내용으로 어떻게 할 수 없는 부분도 있었지만, 해결할 수 있는 부분도 있었다. DB에는 이미지가 bytearray로 저장되어있는데, 프로그램에서는 이미지가 img 형식이기 때문에, bytearray를 img 로 바꾸어주어야 했는데, 이 부분에서 시간이 많이 걸렸다. 그래서 프로그램에서 이미지를 img 형식 대신 bytearray를 사용하게 해서 병목지점을 생략할 수 있었다.    


#### 문제3
