class User:
    def __init__(user, _age: int, _height: float):
        user.age = _age
        user.height = _height


cet: User = User(18, 175.0)
print(f"{cet.age}\n{cet.height}")
