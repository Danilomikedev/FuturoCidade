Feature: Gestão de Dados de Tráfego

  Scenario: Adicionar dados de tráfego
    Given que dados de tráfego para "Avenida Paulista" com 10 veículos
    When os dados de tráfego são adicionados
    Then o sistema deve retornar o status 201

  Scenario: Listar dados de tráfego
    Given dados de tráfego estão cadastrados
    When a lista de dados de tráfego é solicitada
    Then o sistema deve retornar o status 200 e a lista de dados de tráfego
