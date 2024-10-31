Feature: Alertas de Segurança

  Scenario: Criar um novo alerta
    Given que um alerta com a mensagem "Incidente na Avenida" 
    When o alerta é criado
    Then o sistema deve retornar o status 201

  Scenario: Listar alertas
    Given alertas estão cadastrados
    When a lista de alertas é solicitada
    Then o sistema deve retornar o status 200 e a lista de alertas
