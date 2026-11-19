-- ============================================================
-- SIGHA — Sistema Integrado de Gestão Hospitalar e Ambulatorial
-- Script SQL Oficial e Completo — Versão 2.0 (RESTAURADO)
-- Banco de Dados: sigha_db
-- Porta recomendada (XAMPP): 3307
-- Encoding: UTF-8
-- ============================================================

CREATE DATABASE IF NOT EXISTS sigha_db
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE sigha_db;

-- =============================================================
-- TABELA 1: USUÁRIOS DO SISTEMA
-- Formulários vinculados: Tela_Login.cs, panelCadastroUsuario.cs,
--                         Escolha_Modulos.cs (RBAC)
-- =============================================================
CREATE TABLE IF NOT EXISTS Usuarios (
    Id            INT           AUTO_INCREMENT PRIMARY KEY,
    Username      VARCHAR(50)   NOT NULL UNIQUE,
    Password      VARCHAR(255)  NOT NULL COMMENT 'Senha em texto puro (dev) — usar hash em produção',
    Role          VARCHAR(50)   NOT NULL COMMENT 'Administrador | Medico | Enfermeiro | Atendente',
    NomeCompleto  VARCHAR(150)  NOT NULL,
    Setor         VARCHAR(80)   DEFAULT NULL,
    DataCriacao   DATETIME      DEFAULT CURRENT_TIMESTAMP,
    DataExclusao  DATETIME      DEFAULT NULL COMMENT 'Soft-delete'
);

-- Usuários padrão do sistema (senha: 1234)
INSERT IGNORE INTO Usuarios (Username, Password, Role, NomeCompleto, Setor) VALUES
('admin',      '1234', 'Administrador', 'Administrador do Sistema',  'Admin'),
('medico',     '1234', 'Medico',        'Dr. Padrão Silva',          'Medicina'),
('enfermeiro', '1234', 'Enfermeiro',    'Enf. Padrão Santos',        'Enfermagem'),
('atendente',  '1234', 'Atendente',     'Atendente Padrão Costa',    'Atendimento');

-- =============================================================
-- TABELA 2: CONFIGURAÇÕES DA CLÍNICA
-- Formulários vinculados: panelConfiguracoes.cs (Módulo Administrativo)
-- =============================================================
CREATE TABLE IF NOT EXISTS ConfiguracoesClinica (
    Id               INT          AUTO_INCREMENT PRIMARY KEY,
    NomeClinica      VARCHAR(150) DEFAULT 'Clínica SIGHA',
    Cnpj             VARCHAR(20)  DEFAULT '00.000.000/0001-00',
    TelefoneContato  VARCHAR(25)  DEFAULT '(00) 0000-0000',
    Endereco         VARCHAR(255) DEFAULT NULL,
    Email            VARCHAR(150) DEFAULT NULL,
    CorTema          VARCHAR(50)  DEFAULT 'Teal',
    UltimaAtualizacao DATETIME    DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- Configuração padrão
INSERT IGNORE INTO ConfiguracoesClinica (Id, NomeClinica, Cnpj, TelefoneContato, CorTema)
VALUES (1, 'SIGHA — Centro Médico Integrado', '12.345.678/0001-90', '(11) 4002-8922', 'Teal');

-- =============================================================
-- TABELA 3: PACIENTES
-- Formulários vinculados: PanelCadastroPacientes.cs
-- =============================================================
CREATE TABLE IF NOT EXISTS Pacientes (
    Id            INT          AUTO_INCREMENT PRIMARY KEY,
    Cpf           VARCHAR(14)  NOT NULL UNIQUE,
    Nome          VARCHAR(150) NOT NULL,
    DataNascimento DATE         NOT NULL,
    Sexo          VARCHAR(20)  DEFAULT NULL,
    Telefone      VARCHAR(25)  DEFAULT NULL,
    Email         VARCHAR(150) DEFAULT NULL,
    Endereco      VARCHAR(255) DEFAULT NULL,
    DataCadastro  DATETIME     DEFAULT CURRENT_TIMESTAMP
);

-- (Nenhum dado inicial de pacientes)

-- =============================================================
-- TABELA 4: AGENDAMENTOS E PAGAMENTOS
-- Formulários vinculados: AgendamentoConsulta.cs
-- =============================================================
CREATE TABLE IF NOT EXISTS Agendamentos (
    Id                INT            AUTO_INCREMENT PRIMARY KEY,
    PacienteCpf       VARCHAR(14)    DEFAULT NULL,
    NomeProfissional  VARCHAR(100)   DEFAULT NULL,
    Especialidade     VARCHAR(100)   DEFAULT NULL,
    HorarioConsulta   DATETIME       DEFAULT NULL,
    ServicoRealizado  VARCHAR(100)   DEFAULT NULL,
    ValorServico      DECIMAL(10,2)  DEFAULT 0.00,
    FormaPagamento    VARCHAR(50)    DEFAULT 'Dinheiro',
    ValorTotal        DECIMAL(10,2)  DEFAULT 0.00,
    ValorRecebido     DECIMAL(10,2)  DEFAULT 0.00,
    Troco             DECIMAL(10,2)  DEFAULT 0.00,
    Status            VARCHAR(50)    DEFAULT 'Agendado',
    DataCriacao       DATETIME       DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (PacienteCpf) REFERENCES Pacientes(Cpf) ON DELETE SET NULL
);

-- =============================================================
-- TABELA 5: RECEPÇÃO — ENTRADA DE PACIENTES
-- Formulários vinculados: Recepcao.cs, MenuAtendimento.cs (fila)
-- =============================================================
CREATE TABLE IF NOT EXISTS Recepcoes (
    Id                  INT         AUTO_INCREMENT PRIMARY KEY,
    PacienteCpf         VARCHAR(14) NOT NULL,
    SintomasIniciais    TEXT        DEFAULT NULL,
    DataEntrada         DATETIME    DEFAULT CURRENT_TIMESTAMP,
    StatusAtendimento   VARCHAR(50) DEFAULT 'Aguardando Triagem'
        COMMENT 'Aguardando Triagem | Aguardando Medico | Em Atendimento | Finalizado',
    FOREIGN KEY (PacienteCpf) REFERENCES Pacientes(Cpf) ON DELETE CASCADE
);

-- (Nenhum dado inicial de fila)

-- =============================================================
-- TABELA 6: TRIAGEM (Protocolo de Manchester)
-- Formulários vinculados: Triagem.cs
-- =============================================================
CREATE TABLE IF NOT EXISTS Triagens (
    Id               INT         AUTO_INCREMENT PRIMARY KEY,
    RecepcaoId       INT         NOT NULL,
    Evolucao         TEXT        DEFAULT NULL,
    CodigoManchester VARCHAR(50) DEFAULT 'Verde'
        COMMENT 'Vermelho | Laranja | Amarelo | Verde | Azul',
    PressaoArterial  VARCHAR(20) DEFAULT NULL,
    FrequenciaCard   INT         DEFAULT NULL COMMENT 'bpm',
    Temperatura      DECIMAL(4,1) DEFAULT NULL COMMENT 'graus Celsius',
    Saturacao        INT         DEFAULT NULL COMMENT 'SpO2 %',
    DataTriagem      DATETIME    DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (RecepcaoId) REFERENCES Recepcoes(Id) ON DELETE CASCADE
);

-- =============================================================
-- TABELA 7: PRONTUÁRIO / CONSULTAS MÉDICAS
-- Formulários vinculados: PanelConsultorio.cs, PanelHistoricoPaciente.cs
-- =============================================================
CREATE TABLE IF NOT EXISTS ConsultasProntuario (
    Id               INT         AUTO_INCREMENT PRIMARY KEY,
    PacienteCpf      VARCHAR(14) NOT NULL,
    TriagemId        INT         DEFAULT NULL,
    MedicoId         INT         NOT NULL,
    DetalhesConsulta TEXT        DEFAULT NULL,
    Cid10            VARCHAR(10) DEFAULT NULL COMMENT 'Código CID-10 do diagnóstico',
    DataAtendimento  DATETIME    DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (PacienteCpf) REFERENCES Pacientes(Cpf)    ON DELETE CASCADE,
    FOREIGN KEY (TriagemId)   REFERENCES Triagens(Id)      ON DELETE SET NULL,
    FOREIGN KEY (MedicoId)    REFERENCES Usuarios(Id)      ON DELETE CASCADE
);

-- =============================================================
-- TABELA 8: EXAMES LABORATORIAIS / IMAGEM
-- Formulários vinculados: PanelExames.cs
-- =============================================================
CREATE TABLE IF NOT EXISTS Exames (
    Id               INT         AUTO_INCREMENT PRIMARY KEY,
    PacienteCpf      VARCHAR(14) NOT NULL,
    MedicoId         INT         NOT NULL,
    DescricaoExame   TEXT        NOT NULL,
    DataSolicitacao  DATETIME    DEFAULT CURRENT_TIMESTAMP,
    Resultado        TEXT        DEFAULT NULL,
    Status           VARCHAR(50) DEFAULT 'Pendente'
        COMMENT 'Pendente | Em Análise | Concluído | Cancelado',
    FOREIGN KEY (PacienteCpf) REFERENCES Pacientes(Cpf) ON DELETE CASCADE,
    FOREIGN KEY (MedicoId)   REFERENCES Usuarios(Id)   ON DELETE CASCADE
);

-- =============================================================
-- TABELA 9: PRODUTOS E INSUMOS (Farmácia / Estoque)
-- Formulários vinculados: panelCadastrarProduto.cs, panelEstoqueAtual.cs
-- =============================================================
CREATE TABLE IF NOT EXISTS Produtos (
    Id                INT          AUTO_INCREMENT PRIMARY KEY,
    NomeProduto       VARCHAR(150) NOT NULL,
    UnidadeMedida     VARCHAR(50)  NOT NULL COMMENT 'ex: Comprimido, Frasco, Caixa',
    QuantidadeEstoque INT          NOT NULL DEFAULT 0,
    EstoqueMinimo     INT          DEFAULT 10  COMMENT 'Alerta quando menor que este valor',
    Fabricante        VARCHAR(100) DEFAULT NULL,
    Lote              VARCHAR(50)  DEFAULT NULL,
    DataValidade      DATE         DEFAULT NULL,
    DataCadastro      DATETIME     DEFAULT CURRENT_TIMESTAMP
);

-- (Nenhum dado inicial de estoque)

-- =============================================================
-- TABELA 10: MOVIMENTAÇÃO DE ESTOQUE (Entradas e Saídas)
-- Formulários vinculados: panelMovimentacaoEstoque.cs
-- =============================================================
CREATE TABLE IF NOT EXISTS MovimentacaoEstoque (
    Id                    INT         AUTO_INCREMENT PRIMARY KEY,
    ProdutoId             INT         NOT NULL,
    TipoMovimentacao      VARCHAR(20) NOT NULL COMMENT 'Entrada | Saída',
    Quantidade            INT         NOT NULL,
    Observacao            VARCHAR(255) DEFAULT NULL,
    DataMovimentacao      DATETIME    DEFAULT CURRENT_TIMESTAMP,
    UsuarioResponsavelId  INT         DEFAULT NULL,
    FOREIGN KEY (ProdutoId)            REFERENCES Produtos(Id) ON DELETE CASCADE,
    FOREIGN KEY (UsuarioResponsavelId) REFERENCES Usuarios(Id) ON DELETE SET NULL
);

-- (Nenhuma movimentação inicial)

-- Trigger: atualiza QuantidadeEstoque automaticamente após movimentação
DELIMITER $$
CREATE TRIGGER IF NOT EXISTS trg_atualiza_estoque_after_insert
AFTER INSERT ON MovimentacaoEstoque
FOR EACH ROW
BEGIN
    IF NEW.TipoMovimentacao = 'Entrada' THEN
        UPDATE Produtos SET QuantidadeEstoque = QuantidadeEstoque + NEW.Quantidade WHERE Id = NEW.ProdutoId;
    ELSEIF NEW.TipoMovimentacao = 'Saída' THEN
        UPDATE Produtos SET QuantidadeEstoque = QuantidadeEstoque - NEW.Quantidade WHERE Id = NEW.ProdutoId;
    END IF;
END$$
DELIMITER ;

-- =============================================================
-- TABELA 11: REQUISIÇÕES DE INSUMOS (Farmácia → Estoque)
-- Formulários vinculados: panelRequisicoes.cs
-- =============================================================
CREATE TABLE IF NOT EXISTS RequisicoesEstoque (
    Id                  INT         AUTO_INCREMENT PRIMARY KEY,
    SetorSolicitante    VARCHAR(100) NOT NULL,
    ProdutoId           INT          NOT NULL,
    QuantidadeSolicitada INT         NOT NULL,
    Status              VARCHAR(50)  DEFAULT 'Pendente'
        COMMENT 'Pendente | Aprovada | Recusada | Entregue',
    Justificativa       TEXT         DEFAULT NULL,
    DataRequisicao      DATETIME     DEFAULT CURRENT_TIMESTAMP,
    DataResposta        DATETIME     DEFAULT NULL,
    FOREIGN KEY (ProdutoId) REFERENCES Produtos(Id) ON DELETE CASCADE
);

-- (Nenhuma requisição inicial)

-- =============================================================
-- VIEWS ÚTEIS PARA OS RELATÓRIOS
-- =============================================================

-- Visão de Fila de Atendimento
CREATE OR REPLACE VIEW vw_FilaAtendimento AS
SELECT r.Id,
       p.Nome        AS Paciente,
       p.Cpf,
       r.SintomasIniciais AS Sintomas,
       r.StatusAtendimento AS Status,
       r.DataEntrada
FROM   Recepcoes r
JOIN   Pacientes p ON r.PacienteCpf = p.Cpf
WHERE  r.StatusAtendimento <> 'Finalizado'
ORDER  BY r.DataEntrada ASC;

-- Visão de Relatório de Atendimentos do Dia
CREATE OR REPLACE VIEW vw_AtendimentosDia AS
SELECT c.Id,
       p.Nome          AS Paciente,
       u.NomeCompleto  AS Medico,
       c.DetalhesConsulta,
       c.DataAtendimento
FROM   ConsultasProntuario c
JOIN   Pacientes p ON c.PacienteCpf = p.Cpf
JOIN   Usuarios  u ON c.MedicoId    = u.Id
WHERE  DATE(c.DataAtendimento) = CURDATE();

-- Visão de Estoque Crítico
CREATE OR REPLACE VIEW vw_EstoqueCritico AS
SELECT Id, NomeProduto, UnidadeMedida, QuantidadeEstoque, EstoqueMinimo
FROM   Produtos
WHERE  QuantidadeEstoque <= EstoqueMinimo;

-- =============================================================
-- FIM DO SCRIPT — sigha_banco_completo.sql v2.0
-- =============================================================
