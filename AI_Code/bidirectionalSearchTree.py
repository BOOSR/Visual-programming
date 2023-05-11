
class Node:
    def __init__(self, value=None):
        self.value = value
        self.left = None
        self.right = None

def create_bidirectional_tree(numbers):
    if len(numbers) == 0:
        return None
    root = Node(numbers[0])
    for number in numbers[1:]:
        _add_node_bidirectionally(root, Node(number))
    return root

def _add_node_bidirectionally(root, new_node):
    left_moves = 0
    right_moves = 0
    node = root
    while True:
        if new_node.value < node.value:
            if node.left is None:
                node.left = new_node
                new_node.right = node
                break
            else:
                node = node.left
                left_moves += 1
        else:
            if node.right is None:
                node.right = new_node
                new_node.left = node
                break
            else:
                node = node.right
                right_moves += 1
    if left_moves < right_moves:
        new_node.value, node.value = node.value, new_node.value
        new_node.left, node.left = node.left, new_node.left
        node.right, new_node.right = new_node, node.right

# تعریف یک لیست از اعداد برای ایجاد درخت دوطرفه
numbers = [9, 5, 15, 1, 7, 12, 20, 0, 3]

# ایجاد درخت جستجوی دوطرفه
root = create_bidirectional_tree(numbers)

# نمایش درخت با استفاده از تراورس
def traverse_tree_inorder(tree):
    if tree is None:
        return []
    return traverse_tree_inorder(tree.left) + [tree.value] + traverse_tree_inorder(tree.right)

print(traverse_tree_inorder(root))
