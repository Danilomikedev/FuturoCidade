Feature: Gest�o de Dados de Tr�fego

  Scenario: Adicionar dados de tr�fego
    Given que dados de tr�fego para "Avenida Paulista" com 10 ve�culos
    When os dados de tr�fego s�o adicionados
    Then o sistema deve retornar o status 201

  Scenario: Listar dados de tr�fego
    Given dados de tr�fego est�o cadastrados
    When a lista de dados de tr�fego � solicitada
    Then o sistema deve retornar o status 200 e a lista de dados de tr�fego
