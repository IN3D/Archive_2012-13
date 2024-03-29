##Animal is-a object (yes, sort of confusing) look at the extra credit
class Animal(object):
	pass

## ?? / Dog is-a Animal
class Dog(Animal):

	def __init__(self, name):
		## ?? / Dog has-a name
		self.name = name

## ?? / Cat is-a Animal
class Cat(Animal):

	def __init__(self, name):
		## ?? / Cat has-a name
		self.name = name

## ?? / Person is-a object
class Person(object):

	def __init__(self, name):
		## ?? / Person has-a name
		self.name = name

		## Person has-a pet of some kind
		self.pet = None

## ??
class Employee(Person):

	def __init__(self, name, salary):
		## ?? hmm what is this strange magic? / Super uses the constructor of the parent class
		super(Employee, self).__init__(name)
		## ?? / Employee has-a salary
		self.salary = salary

## ?? / Fish is-a object
class Fish(object):
	pass

## ?? / Salmon is-a fish
class Salmon(Fish):
	pass

## ?? / Halibut is-a fish
class Halibut(Fish):
	pass

## rover is-a Dog
rover = Dog("Rover")

## ?? / satan is-a cat
satan = Cat("Satan")

## ?? / mary is-a person
mary = Person("Mary")

## ?? / mary has-a pet, that pet is satan the Cat
mary.pet = satan

## ?? / frank is an Employee (and a person)
frank = Employee("Frank", 120000)

## ?? / frank has a pet, the dog rover
frank.pet = rover

## ?? / flipper is-a fish
flipper = Fish()

## ?? / crouse is a salmon (which is a fish)
crouse = Salmon()

## ?? / harry is a halibut (which is a fish)
harry = Halibut()