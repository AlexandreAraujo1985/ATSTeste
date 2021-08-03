"# ATSTeste" 
Abaixo os passos para executar o sistema em ambiente localhost

Configurando o backend
1.  Abrir a IDE Visual Studio 
2.  Abrir a guia Package Manager Console
3. Selecionar o projeto ATSBackend.Infra.Data
  
  3.1.  Add-Migration Initial
  
  3.2.  Update-Database -Verbose
  
4.  Após a criação da base de dados via migrations execute o projeto para habilitar a API

Configurando o Frontend
1. Execute o cmd e abra a pasta onde esta localizado o diretório do Frontent clonado exemplo:  C:\...\ATSFrontend
2. No cmd execute o comando npm start e acesse o site http://localhost:4200/ 

Importante para executar o site é preciso ter instalado o Node.js
