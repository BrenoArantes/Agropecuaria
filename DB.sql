-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 26-Ago-2018 às 21:31
-- Versão do servidor: 10.1.32-MariaDB
-- PHP Version: 7.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `agropecuaria`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoria`
--

CREATE TABLE `categoria` (
  `cod_categoria` int(11) NOT NULL,
  `data_cadastro_categoria` datetime NOT NULL,
  `nome_categoria` varchar(40) NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `cod_cliente` int(11) NOT NULL,
  `nome` varchar(40) NOT NULL,
  `tel_celular` char(14) DEFAULT NULL,
  `tel_celular2` char(14) DEFAULT NULL,
  `status` bit(1) DEFAULT NULL,
  `rua` varchar(40) DEFAULT NULL,
  `bairro` varchar(40) DEFAULT NULL,
  `numero` int(11) DEFAULT NULL,
  `cidade` varchar(40) DEFAULT NULL,
  `sexo` bit(1) DEFAULT NULL,
  `rg` char(12) NOT NULL,
  `cpf` char(14) NOT NULL,
  `data_nascimento` datetime NOT NULL,
  `data_cadastro` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`cod_cliente`, `nome`, `tel_celular`, `tel_celular2`, `status`, `rua`, `bairro`, `numero`, `cidade`, `sexo`, `rg`, `cpf`, `data_nascimento`, `data_cadastro`) VALUES
(1, 'Nome', '(  )     -', '(  )     -', b'1', '', '', 0, 'Cidade', b'1', '  .   .   -', '223.432.123-43', '2012-12-12 00:00:00', '2018-08-23 22:00:02');

-- --------------------------------------------------------

--
-- Estrutura da tabela `estaem`
--

CREATE TABLE `estaem` (
  `cod_itens_vendas` int(11) NOT NULL,
  `cod_venda` int(11) DEFAULT NULL,
  `cod_produto` int(11) DEFAULT NULL,
  `qtde` int(11) NOT NULL,
  `preco` decimal(6,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE `funcionarios` (
  `cod_funcionario` int(11) NOT NULL,
  `rg` char(12) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `data_nascimento` datetime NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `rua` varchar(40) DEFAULT NULL,
  `bairro` varchar(40) DEFAULT NULL,
  `cidade` varchar(40) DEFAULT NULL,
  `numero_casa` int(11) DEFAULT NULL,
  `senha_funcionario` varchar(20) NOT NULL,
  `login_funcionario` varchar(20) NOT NULL,
  `tel_celular` char(14) DEFAULT NULL,
  `status` bit(1) NOT NULL,
  `nome` varchar(40) NOT NULL,
  `sexo` bit(1) DEFAULT NULL,
  `tel_celular2` char(14) DEFAULT NULL,
  `funcao` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`cod_funcionario`, `rg`, `cpf`, `data_nascimento`, `data_cadastro`, `rua`, `bairro`, `cidade`, `numero_casa`, `senha_funcionario`, `login_funcionario`, `tel_celular`, `status`, `nome`, `sexo`, `tel_celular2`, `funcao`) VALUES
(1, '12.345.432-x', '123.454.321-34', '2012-00-12 00:00:00', '2018-08-21 17:18:05', 'rua', 'bairro', 'cidade', 0, 'Senha0', 'Login0', '(12)34567-8765', b'1', 'nome', b'1', '(12)34567-8765', ''),
(2, '  .   .   -', '123.454.321-23', '2012-00-12 00:00:00', '2018-08-21 17:22:43', '', '', 'cidade', 0, '', '', '(  )     -', b'1', 'nome', b'1', '(  )     -', 'função'),
(3, '41.241.353-x', '214.124.124-14', '2012-12-12 00:00:00', '2018-08-23 21:50:17', 'Rua', 'Bairro', 'Cidade', 0, 'Senha', 'Login', '(21)31241-5135', b'1', 'Nome', b'1', '(21)31241-5135', 'Função'),
(16, '34.325.325-z', '123.456.432-13', '2012-12-12 00:00:00', '2018-08-23 22:10:05', '', '', 'Cidade', 0, 'Senha', 'Login2', '(  )     -', b'1', 'Nome', b'1', '(  )     -', ''),
(18, '34.325.325-x', '123.456.432-14', '2012-12-12 00:00:00', '2018-08-23 22:12:53', '', '', 'Cidade', 0, 'Senha', 'Login3', '(  )     -', b'1', 'Nome', b'1', '(  )     -', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `marca`
--

CREATE TABLE `marca` (
  `cod_marca` int(11) NOT NULL,
  `data_cadastro_marca` datetime NOT NULL,
  `nome_marca` varchar(40) NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `cod_produto` int(11) NOT NULL,
  `cod_marca` int(11) NOT NULL,
  `cod_categoria` int(11) NOT NULL,
  `nome_produto` varchar(50) NOT NULL,
  `preço` decimal(6,2) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE `venda` (
  `cod_venda` int(11) NOT NULL,
  `cod_funcionario` int(11) NOT NULL,
  `cod_cliente` int(11) NOT NULL,
  `data_compra` datetime NOT NULL,
  `nome_cliente` varchar(40) NOT NULL,
  `valor_total` decimal(6,2) NOT NULL,
  `forma_pagamento` varchar(20) NOT NULL,
  `status` bit(1) NOT NULL,
  `qtde_itens` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`cod_categoria`),
  ADD UNIQUE KEY `nome_categoria` (`nome_categoria`);

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`cod_cliente`),
  ADD UNIQUE KEY `rg` (`rg`),
  ADD UNIQUE KEY `cpf` (`cpf`);

--
-- Indexes for table `estaem`
--
ALTER TABLE `estaem`
  ADD PRIMARY KEY (`cod_itens_vendas`),
  ADD KEY `cod_venda` (`cod_venda`),
  ADD KEY `cod_produto` (`cod_produto`);

--
-- Indexes for table `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`cod_funcionario`),
  ADD UNIQUE KEY `rg` (`rg`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD UNIQUE KEY `login_funcionario` (`login_funcionario`);

--
-- Indexes for table `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`cod_marca`),
  ADD UNIQUE KEY `nome_marca` (`nome_marca`);

--
-- Indexes for table `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`cod_produto`),
  ADD UNIQUE KEY `nome_produto` (`nome_produto`),
  ADD KEY `cod_marca` (`cod_marca`),
  ADD KEY `cod_categoria` (`cod_categoria`);

--
-- Indexes for table `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`cod_venda`),
  ADD KEY `cod_funcionario` (`cod_funcionario`),
  ADD KEY `cod_cliente` (`cod_cliente`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categoria`
--
ALTER TABLE `categoria`
  MODIFY `cod_categoria` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `cod_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `estaem`
--
ALTER TABLE `estaem`
  MODIFY `cod_itens_vendas` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `cod_funcionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `marca`
--
ALTER TABLE `marca`
  MODIFY `cod_marca` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `produtos`
--
ALTER TABLE `produtos`
  MODIFY `cod_produto` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `venda`
--
ALTER TABLE `venda`
  MODIFY `cod_venda` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `estaem`
--
ALTER TABLE `estaem`
  ADD CONSTRAINT `estaem_ibfk_1` FOREIGN KEY (`cod_venda`) REFERENCES `venda` (`cod_venda`),
  ADD CONSTRAINT `estaem_ibfk_2` FOREIGN KEY (`cod_produto`) REFERENCES `produtos` (`cod_produto`);

--
-- Limitadores para a tabela `produtos`
--
ALTER TABLE `produtos`
  ADD CONSTRAINT `produtos_ibfk_1` FOREIGN KEY (`cod_marca`) REFERENCES `marca` (`cod_marca`),
  ADD CONSTRAINT `produtos_ibfk_2` FOREIGN KEY (`cod_categoria`) REFERENCES `categoria` (`cod_categoria`);

--
-- Limitadores para a tabela `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `venda_ibfk_1` FOREIGN KEY (`cod_funcionario`) REFERENCES `funcionarios` (`cod_funcionario`),
  ADD CONSTRAINT `venda_ibfk_2` FOREIGN KEY (`cod_cliente`) REFERENCES `cliente` (`cod_cliente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
