# SIGHA

Sistema Integrado de Gestão Hospitalar e Ambulatorial. Projeto da Situação de Aprendizagem final do curso Técnico em Desenvolvimento de Sistemas do SENAI.

O sistema reúne cadastro de pacientes, agendamento de consultas, triagem, atendimento, controle de estoque e relatórios. Foi feito em C# com Windows Forms (.NET 10) e MySQL.

## Como rodar

1. Execute o [script do banco](Sistema/sigha_banco_completo.sql) no MySQL.
2. Confira a conexão em [`DatabaseConfig.cs`](Sistema/SIGHA/Services/DatabaseConfig.cs). O projeto usa a porta `3307` por padrão.
3. No Windows, abra [`SIGHA.slnx`](Sistema/SIGHA.slnx) no Visual Studio e pressione `F5`.

Os diagramas estão na pasta [Documentacao](Documentacao).
